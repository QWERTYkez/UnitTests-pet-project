using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppigCartLib
{
    public class ShoppigCart
    {
        public List<Item> Items = new List<Item>();

        public int Count
        {
            get { return Items.Count; }
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Remove(int index)
        {
            Items.RemoveAt(index);
        }

        public void Dispose()
        {
            Items = null;
        }
    }

    public class Item
    {
        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name;
        public int Quantity;
    }
}
