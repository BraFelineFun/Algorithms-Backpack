// See https://aka.ms/new-console-template for more information

namespace BackPack_UI
{


        // Node structure to store information of decision
        // tree
        public class Node
        {
            public Node left, right;
            public ItemList arr;

            public int upper;
            public double cost;

            public Node(ItemList arr)
            {
                this.arr = arr;
                left = right = null;
            }

            public void countUpper(int W)
            {
                int sum = 0;
                for(int i =0; i < arr.Length && sum < W;i++)
                {
                    upper += arr.GetElement(i).cost;
                    sum += arr.GetElement(i).weight;
                }

                sum = 0;
                for(int i = 0;i < arr.Length && sum < W;i++)
                {
                    if (sum + arr.GetElement(i).weight > W)
                    {
                        cost += arr.GetElement(i).cost * (W - sum);
                    }
                    else
                        cost += arr.GetElement(i).cost;
                }    
            }


        }

        class BranchAndBound
        {
            ItemList solution;
            public int weight;
            public int cost;
            
            public BranchAndBound()
            {
                solution = new ItemList();
                weight = -1;
                cost = -1;
            }
            static public void Dive(Node root,int i, int W, ItemList arrayAll, int sumCurrent)
                {
                if (i < arrayAll.Length)
                {
                    if (sumCurrent + arrayAll.GetElement(i).weight <= W)
                    {
                        ItemList newArray = new ItemList();
                        foreach (Item obj in root.arr)
                            newArray.Add(obj);
                        newArray.Add(arrayAll.GetElement(i));
                        root.left = new Node(newArray);
                        Dive(root.left, i + 1, W, arrayAll, sumCurrent + arrayAll.GetElement(i).weight);
                    }
                    root.right = new Node(root.arr);
                    Dive(root.right, i +1, W,  arrayAll, sumCurrent);
                }

                   root.countUpper(W);
                   return;
                
                }
            public void FindBest(Node root, ref int profit)
            {
                //solution = new ItemList();
                if (root == null)
                    return;
                FindBest(root.left, ref profit);
                FindBest(root.right, ref profit);

                if (root.upper > profit)
                {         
                    solution = root.arr;                
                    profit = root.upper;
                    cost = root.upper;
                    weight = root.arr.GetWeight();
                } 

            }
            static public BackPack Solve(ItemList arr, int W)
            {
                arr.Sort();
                ItemList arrayPust = new ItemList();
                Node root = new Node(arrayPust);
                Dive(root, 0 ,W , arr ,0);
                int profit = 0;
                ItemList solution = new ItemList();
                BranchAndBound temp = new BranchAndBound();
                temp.FindBest(root, ref profit);


                BackPack res = new BackPack(W, Convert.ToInt32(temp.weight), Convert.ToInt32(temp.cost), temp.solution);                
                return res;            
            }

          
        }

    }
