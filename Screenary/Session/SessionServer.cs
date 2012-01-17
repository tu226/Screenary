using System;
using System.IO;
using System.Threading;
using System.Collections;

namespace Screenary
{	
	public class SessionServer : SessionChannel
	{
		private ISessionRequestListener listener;
		private readonly object channelLock = new object();
				
		public SessionServer(TransportClient transport, ISessionRequestListener listener)
		{
			this.transport = transport;
			this.listener = listener;
		}
		
		private BinaryWriter InitRspPDU(ref byte[] buffer, int length, UInt32 id, UInt32 status)
		{
			BinaryWriter s;
			
			buffer = new byte[length + 8];
			s = new BinaryWriter(new MemoryStream(buffer));
			
			s.Write((UInt32) id);
			s.Write((UInt32) status);
	
			return s;
		}
		
		public void SendJoinRsp(UInt32 sessionId, char[] sessionKey, string userid, UInt32 sessionStatus, byte sessionFlags)
		{
			Console.WriteLine("SessionServer.SendJoinRsp");
									
			byte[] buffer = null;
			int length = sessionKey.Length +userid.Length + 1 + 4;
			BinaryWriter s = InitRspPDU(ref buffer, length, sessionId, sessionStatus);
			s.Write((UInt16) sessionKey.Length);			
			s.Write(sessionKey);
			s.Write((UInt16) userid.Length);			
			s.Write(userid.ToCharArray());
			s.Write(sessionFlags);

			Send(buffer, PDU_SESSION_JOIN_RSP);
		}
		
		public void SendLeaveRsp(UInt32 sessionId, UInt32 sessionStatus)
		{
			Console.WriteLine("SessionClient.SendLeaveRsp");
									
			byte[] buffer = null;
			int length = 0;
			BinaryWriter s = InitRspPDU(ref buffer, length, sessionId, sessionStatus);
						
			Send(buffer, PDU_SESSION_LEAVE_RSP);
		}
		
		public void SendAuthRsp(UInt32 sessionId, UInt32 sessionStatus)
		{
			Console.WriteLine("SessionClient.SendAuthRsp");
			
			byte[] buffer = null;
			int length = 0;
			BinaryWriter s = InitRspPDU(ref buffer, length, sessionId, sessionStatus);
									
			Send(buffer, PDU_SESSION_AUTH_RSP);			
		}
		
		public void SendCreateRsp(UInt32 sessionId, char[] sessionKey)
		{
			Console.WriteLine("SessionServer.SendCreateRsp");
						
			UInt32 sessionStatus = 0;
			
			byte[] buffer = null;
			int length = sessionKey.Length;
			BinaryWriter s = InitRspPDU(ref buffer, length, sessionId, sessionStatus);
			
			s.Write(sessionKey);
			
			Send(buffer, PDU_SESSION_CREATE_RSP);
		}
		
		public void SendTermRsp(UInt32 sessionId, char[] sessionKey, UInt32 sessionStatus)
		{
			Console.WriteLine("SessionClient.SendTermRsp");

			byte[] buffer = null;
			int length = sessionKey.Length;
			BinaryWriter s = InitRspPDU(ref buffer, length, sessionId, sessionStatus);
			
			s.Write(sessionKey);
			
			Send(buffer, PDU_SESSION_TERM_RSP);
		}
		
		private void RecvJoinReq(BinaryReader s)
		{
			Console.WriteLine("SessionClient.RecvJoinReq");
			
			UInt32 sessionId;
			char[] sessionKey;
			
			sessionId = s.ReadUInt32();
			
			UInt16 sessionKeyLength = s.ReadUInt16();
			sessionKey = s.ReadChars(sessionKeyLength);
			
			UInt16 usernameLength;
			UInt16 passwordLength;
			string username = "";
			string password = "";
			
			usernameLength = s.ReadUInt16();
			passwordLength = s.ReadUInt16();
			
			if (usernameLength > 0)
				username = new string(s.ReadChars(usernameLength));
			
			if (passwordLength > 0)
				password = new string(s.ReadChars(passwordLength));
			
			listener.OnSessionJoinRequested(sessionKey, username, password);
		}
		
		private void RecvLeaveReq(BinaryReader s)
		{
			Console.WriteLine("SessionClient.RecvLeaveReq");

			UInt32 sessionId = s.ReadUInt32();
			
			UInt16 sessionKeyLength;
			UInt16 useridLength;
			string sessionKey = "";
			string userid = "";
			
			sessionKeyLength = s.ReadUInt16();
			
			if (sessionKeyLength > 0)
				sessionKey = new string(s.ReadChars(sessionKeyLength));
			
			useridLength = s.ReadUInt16();		
			
			if (useridLength > 0)
				userid = new string(s.ReadChars(useridLength));
			
			listener.OnSessionLeaveRequested(sessionId, sessionKey, userid);
		}
		
		private void RecvAuthReq(BinaryReader s)
		{
			Console.WriteLine("SessionClient.RecvAuthReq");

			UInt32 sessionId;
			UInt16 usernameLength;
			UInt16 passwordLength;
			string username = "";
			string password = "";
			
			sessionId = s.ReadUInt32();
			usernameLength = s.ReadUInt16();
			passwordLength = s.ReadUInt16();
			
			if (usernameLength > 0)
				username = new string(s.ReadChars(usernameLength));
			
			if (passwordLength > 0)
				password = new string(s.ReadChars(passwordLength));
					
			listener.OnSessionAuthenticationRequested(sessionId, username, password);
		}
		
		private void RecvCreateReq(BinaryReader s)
		{
			Console.WriteLine("SessionServer.RecvCreateReq");
			
			UInt32 sessionId;
			string username = "";
			string password = "";
			UInt16 usernameLength;
			UInt16 passwordLength;
			
			sessionId = s.ReadUInt32();
			usernameLength = s.ReadUInt16();
			passwordLength = s.ReadUInt16();
			
			if (usernameLength > 0)
				username = new string(s.ReadChars(usernameLength));
			
			if (passwordLength > 0)
				password = new string(s.ReadChars(passwordLength));
			
			listener.OnSessionCreateRequested(username, password);
		}
		
		private void RecvTermReq(BinaryReader s)
		{
			Console.WriteLine("SessionServer.RecvTermReq");

			UInt32 sessionId;
			char[] sessionKey;
			UInt32 sessionStatus;
						
			sessionId = s.ReadUInt32();
			sessionKey = s.ReadChars(12);
			sessionStatus = s.ReadUInt32();
			
			if (sessionStatus != 0)
			{
				Console.WriteLine("Session Termination Failed: {0}", sessionStatus);
				//return;
			}
			
			listener.OnSessionTerminationRequested(sessionId, sessionKey, sessionStatus);
		}
		
		public override void OnRecv(byte[] buffer, byte pduType)
		{
			Console.WriteLine("SessionServer.OnRecv");
			
			lock (channelLock)
			{
				queue.Enqueue(new PDU(buffer, GetChannelId(), pduType));
				Monitor.Pulse(channelLock);
			}
		}
		
		public override void OnOpen()
		{
			Console.WriteLine("SessionServer.OnOpen");
			thread = new Thread(ChannelThreadProc);
			thread.Start();
		}
		
		public override void OnClose()
		{
			Console.WriteLine("SessionServer.OnClose");
			
		}
		
		private void ProcessPDU(byte[] buffer, byte pduType)
		{
			MemoryStream stream = new MemoryStream(buffer);
			BinaryReader s = new BinaryReader(stream);
			
			switch (pduType)
			{
				case PDU_SESSION_JOIN_REQ:
					RecvJoinReq(s);
					return;
				
				case PDU_SESSION_LEAVE_REQ:
					RecvLeaveReq(s);
					return;
				
				case PDU_SESSION_CREATE_REQ:
					RecvCreateReq(s);
					return;
				
				case PDU_SESSION_TERM_REQ:
					RecvTermReq(s);
					return;
				
				case PDU_SESSION_AUTH_REQ:
					RecvAuthReq(s);
					return;
				
				default:
					return;
			}
		}
		
		public void ChannelThreadProc()
		{
			Console.WriteLine("SessionServer.ChannelThreadProc");
			
			while (true)
			{
				lock (channelLock)
				{
					Monitor.Wait(channelLock);
					PDU pdu = (PDU) queue.Dequeue();
					ProcessPDU(pdu.Buffer, pdu.Type);
					Monitor.Pulse(channelLock);
				}
			}
		}
	}
}
