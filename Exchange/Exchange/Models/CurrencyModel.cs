using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    public class CurrencyModel
    {
        public string Name { get; set; }
        public double Diff { get; set; }

        public CurrencyModel(string nm, double dif)
        {
            Name = nm;
            Diff = dif;
        }
    }
}
