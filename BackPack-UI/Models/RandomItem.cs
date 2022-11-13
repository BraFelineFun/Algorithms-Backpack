using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack_UI
{
    public class RandomItem
    {


        public static (int,int) GetRItem(int W)
        {
            Random R = new Random();
            int weight = R.Next(1, W);
            int cost = R.Next(1, 100);

            return (weight, cost);

        }

    }
}
