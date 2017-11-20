using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class DataRow
    {
        public DataRow(Symbol symbol)
        {
            DateTime = DateTime.Now;
            Name = symbol.Name;
            ShortPercent = symbol.ShortPercentage;
            LongPercent = symbol.LongPercentage;
            ShortVolume = symbol.ShortVolume;
            LongVolume = symbol.LongVolume;
            ShortPositions = symbol.ShortPositions;
            LongPositions = symbol.LongPositions;
        }

        [Key, Column(Order = 0)]
        public DateTime DateTime { get; set; }
        [Key, Column(Order = 1)]
        public string Name { get; set; }
        public int ShortPercent { get; set; }
        public int LongPercent { get; set; }

        public decimal ShortVolume { get; set; }
        public decimal LongVolume { get; set; }

        public int ShortPositions { get; set; }
        public int LongPositions { get; set; }

    }
}
