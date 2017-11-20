using Core;
using Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Timers;

namespace Console
{
    class Program
    {
        static System.Timers.Timer timer;

        static string sessionId = string.Empty;

        static WebClient client = new WebClient();
        static void Main(string[] args)
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 60000;
            timer.Start();
            Timer_Elapsed(null, null);
            System.Console.ReadLine();

        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(sessionId == string.Empty)
            {
                var data = client.DownloadData("https://www.myfxbook.com/api/login.json?email=ilya.solomka@gmail.com&password=qwerty1234");
                var str = Encoding.ASCII.GetString(data);
                var response = JsonConvert.DeserializeObject<LoginResponse>(str);
                if(!response.Error)
                {
                    sessionId = response.Session;
                }
            }
            else
            {   
                var data = client.DownloadData("http://www.myfxbook.com/api/get-community-outlook.json?session=" + sessionId);
                var res = Encoding.ASCII.GetString(data);
                var outlookResp = JsonConvert.DeserializeObject<OutlookResponse>(res);
                if(!outlookResp.Error)
                {
                    using (var context = new EntityContext())
                    {
                        foreach (var symbol in outlookResp.Symbols)
                        {
                            var row = new DataRow(symbol);
                            context.Symbols.Add(row);
                        }
                        context.SaveChanges();
                        outlookResp.ToConsole();
                    }
                }
            }
        }
    }
}
