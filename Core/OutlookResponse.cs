using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class OutlookResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public IEnumerable<Symbol> Symbols { get; set; }
        public General General { get; set; }

        public void ToConsole()
        {
            var temp = Symbols.Where(x => x.Name == "EURUSD");
            foreach (var t in temp)
            {
                Console.WriteLine("{0} : {1} / {2}", t.Name, t.ShortPercentage, t.LongPercentage);
            }
        }
        public override string ToString()
        {
            
            return string.Empty;
        }
    }
}
