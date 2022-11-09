using System;
using System.Collections;

namespace BackPack_UI
{
    class ItemList : IEnumerable<Item>
    {
        List<Item> items;
        public int Length
        {
            get
            {
                return items.Count;
            }
        }
        public ItemList()
        {
            items = new List<Item>();
        }
        ItemList(List<Item> items)
        {
            this.items = items;
        }
        public bool Add(Item item)
        {
            if (items.Contains(item))
                return false;

            items.Add(item);
            return true;
        }
        public bool Remove(Item item)
        {
            if (!items.Contains(item))
                return false;

            items = items.Where(currentItem => item.id != currentItem.id).ToList();
            return true;
        }
        public ItemList CopyItems()
        {
            return new ItemList(items.ToList());
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            string res = "";
            foreach (Item item in items)
                res += "{" + item.ToString() + "};\n";
            return res;
        }
    }
}
