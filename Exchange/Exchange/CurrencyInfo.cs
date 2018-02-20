using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class CurrencyInfo
    {
        public string Name{get; set;}
        public double diff { get; set; }
        public CurrencyInfo(string nm, double dif)
        {
            Name = nm;
            diff = dif;
        }
    }
}
