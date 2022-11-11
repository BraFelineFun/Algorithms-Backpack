using System;
using System.Collections;

namespace BackPack_UI
{
    public class ItemList : IEnumerable<Item>
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

        public int GetWeight()
        {
            int res = 0;
            foreach (Item obj in items)
                res += obj.weight;
            return res;
        }
        public Item GetElement(int i)
        {
            return this.items[i];
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

        public void Sort()
        {
            for (int i = 0; i < this.items.Count - 1; i++)
                for (int j = i + 1; j < this.items.Count - 1; j++)
                    if (this.items[i].unitCost > this.items[j].unitCost)
                    {
                        Item temp = this.items[i];
                        this.items[i] = this.items[j];
                        this.items[j] = temp;
                    }

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
