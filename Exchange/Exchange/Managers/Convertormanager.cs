using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Managers
{
    public class ConvertorManager
    {
        private static List<CurrencyModel> _items;

        public ConvertorManager()
        {
            _items = new List<CurrencyModel>
            {
                new CurrencyModel("UAH", 1),
                new CurrencyModel("EUR", 35),
                new CurrencyModel("USD", 27),
                new CurrencyModel("RUB", 0.42),
                new CurrencyModel("HUF", 0.107)
            };
        }

        public List<CurrencyModel> GetItems()
        {
            return _items;
        }

        public void AddItem(CurrencyModel item)
        {
            _items.Add(item);
        }

        public void RemoveItem(int indexItem)
        {
            _items.RemoveAt(indexItem);
        }

        public double Convert(int from, int to, double inner)
        {
            return _items[from].Diff * inner / _items[to].Diff;
        }
    }
}
