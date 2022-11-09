using System;
using System.Collections.Generic;

namespace BackPack_UI
{
    class SimpleSolver
    {
        static BackPack Recursive(ItemList items, BackPack backPack, BackPack? bestPack)
        {
            if (bestPack == null)
                bestPack = backPack.CopyBackPack();


            foreach (Item item in items)
            {
                BackPack currBackpack = backPack.CopyBackPack();
                ItemList currItems = items.CopyItems();

                if (!currBackpack.AddItem(item))
                    continue;
                currItems.Remove(item);

                if (bestPack.currentCost < currBackpack.currentCost)
                    bestPack = currBackpack.CopyBackPack();

                currBackpack = Recursive(currItems, currBackpack, bestPack);

                if (bestPack.currentCost < currBackpack.currentCost)
                    bestPack = currBackpack.CopyBackPack();
            }
            return bestPack;
        }

        static public BackPack Solve(ItemList items, BackPack backPack)
        {
            BackPack backpack = Recursive(items, backPack, null);

            return backpack;
        }
    }
}
