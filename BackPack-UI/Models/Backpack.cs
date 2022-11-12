using System;
using System.Collections.Generic;

namespace BackPack_UI
{
    public class BackPack
    {
        int weightCapacity;
        int currentWeight;
        public int currentCost;
        public ItemList containedItems;


        public BackPack(int capacity)
        {
            weightCapacity = capacity;
            containedItems = new ItemList();
            currentWeight = 0;
            currentCost = 0;
        }
        public BackPack(int weightCapacity, int currentWeight, int currentCost, ItemList containedItems)
        {
            this.weightCapacity = weightCapacity;
            this.currentWeight = currentWeight;
            this.currentCost = currentCost;
            this.containedItems = containedItems.CopyItems();
        }
        
        public int GetCapacity()
        {
            return weightCapacity;
        }

        public bool AddItem(Item item)
        {
            if (currentWeight + item.weight <= weightCapacity)
            {
                containedItems.Add(item);
                currentWeight += item.weight;
                currentCost += item.cost;
                return true;
            }
            else
                return false;
        }

        public BackPack CopyBackPack()
        {
            return new BackPack(weightCapacity, currentWeight, currentCost, containedItems);
        }

        public override string ToString()
        {
            return "{ \n\tcurrentItems = [\n" + containedItems.ToString() + "]\n\tcurrentWeight = " + currentWeight + "\n\tcurrentCost = " + currentCost + "\n}";
        }
    }
}
