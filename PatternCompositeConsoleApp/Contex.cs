using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeConsoleApp
{
    class Contex
    {     
        public string[,] nodes = new string[,]
            {
                { "Liverpool v Chelsi", "Over/Under 0,5", "Over/Under 1,5", "Over/Under 2,5", "Over/Under 3,5", "Over/Under 4,5"},
                { "Real v Atletic", "Over/Under 5,5", "Over/Under 6,5", "Over/Under 7,5", "Over/Under 8,5", "Over/Under 9,5"},
                { "Milan v Lacio", "Over/Under 10,5", "Over/Under 11,5", "Over/Under 12,5", "Over/Under 13,5", "Over/Under 14,5"},
                { "Everton v VestHem", "Over/Under 15,5", "Over/Under 16,5", "Over/Under 17,5", "Over/Under 18,5", "Over/Under 19,5"},
                { "Arsenal v Bolton", "Over/Under 20,5", "Over/Under 21,5", "Over/Under 22,5", "Over/Under 23,5", "Over/Under 24,5"},
            };
        public int RowCount { get; set; }
        public int CollumCount { get; set; }
        public int PositionRow { get; set; }
        public int PositionCollum { get; set; }
        public bool Result { get; set; }
        public Contex()
        {
            CollumCount = 6;
            RowCount = 5;
        }
    }
}
