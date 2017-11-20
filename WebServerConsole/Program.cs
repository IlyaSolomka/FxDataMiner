using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server(8090);
            Console.ReadLine();
        }
    }
}
