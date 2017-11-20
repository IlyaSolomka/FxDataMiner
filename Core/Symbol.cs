using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class Symbol
    {
        public string Name { get; set; }
        public int ShortPercentage { get; set; }
        public int LongPercentage { get; set; }
        public decimal ShortVolume { get; set; }
        public decimal LongVolume { get; set; }
        public int LongPositions { get; set; }
        public int ShortPositions { get; set; }
        public int TotalPositions { get; set; }
        public decimal AvgShortPrice { get; set; }
        public decimal AvgLongPrice { get; set; }
    }
}
