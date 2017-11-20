using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WebServerConsole
{
    class Server
    {
        TcpListener tcpListener;

        public Server(int port)
        {
            tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            
            while(true)
            {
                Client.Work(tcpListener.AcceptTcpClient());
            }
        }

    }

    
}
