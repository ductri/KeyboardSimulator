using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace KeyboardSimulator_Server
{
    class ConnectUnit
    {
        IPEndPoint _ipep;
        Socket _socket;
        Socket _client;
        Thread thread;
        RecieveChar t;

        public void startServer()
        {
            IPAddress ip=null;
            IPHostEntry host=Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress i in host.AddressList)
            {
                if (i.AddressFamily==AddressFamily.InterNetwork)
                {
                    ip=i;
                    break;
                }
            }

            _ipep = new IPEndPoint(ip,0);
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            _socket.Bind(_ipep);
            _socket.Listen(5);

        }
        public void startListen()
        {
            thread = new Thread(delegate()
            {
                run();
            });
            thread.Start();
        }
        public void stopListen()
        {
            
        }
        private void run()
        {
            try
            {
                _client = _socket.Accept();
            }
            catch (Exception e)
            { }
        }

        public void sendChar(char c)
        {
            byte[] data=new byte[1];
            data = Encoding.ASCII.GetBytes(c.ToString());
            _client.Send(data,1,SocketFlags.None);
        }

        //For client
        public void startConnect(String ip,int port)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _client.Connect(ipep);
        }
        public char recieve()
        {

            byte[] data = new byte[1];
            _client.Receive(data);
            return (char)data[0];
        }

        public String getIP()
        {
            if (_socket != null)
                return ((IPEndPoint)_socket.LocalEndPoint).Address.ToString();
            else return "";
        }
        public String getPort()
        {
            if (_socket != null)
                return ((IPEndPoint)_socket.LocalEndPoint).Port.ToString();
            else return "";
        }

        public String getIPClient()
        {
            if (_client != null)
                return ((IPEndPoint)_client.RemoteEndPoint).Address.ToString();
            else return "";
        }

        public void close()
        {
            if (_client!=null)
                _client.Close();
            if (_socket != null)
                _socket.Close();
            if (thread != null)
                thread.Abort();
        }
    }

    interface RecieveChar{
        void recieveCharHandler(char c);
    }
}
