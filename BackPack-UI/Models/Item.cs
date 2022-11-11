using System;
using System.Collections;

namespace BackPack_UI
{
    public class Item
    {
        public int weight;
        public int cost;
        public long id;
        public double unitCost;

        public Item(int weight, int cost)
        {
            id = DateTime.Now.Ticks;
            this.weight = weight;
            this.cost = cost;
            unitCost = cost / weight;
        }

        override public string ToString()
        {
            return "id = " + id + ", weight = " + weight + ", cost = " + cost + ";";
        }
    }
}
