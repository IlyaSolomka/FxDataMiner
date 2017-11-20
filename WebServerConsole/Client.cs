using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace WebServerConsole
{
    class Client
    {
        public static void Work (TcpClient client)
        {
            string buffer = string.Empty;
            var stream = client.GetStream();
            using (var streamReader = new StreamReader(stream))
            {
                buffer = streamReader.ReadToEnd();
            }

            //сгенерить ответ на запрос
            var result = "";
            //var b = Encoding.ASCII.GetBytes(result);
            using (var streamWriter = new StreamWriter(stream))
            {
                streamWriter.Write(result);
            }
        }
    }
}
