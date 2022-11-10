// See https://aka.ms/new-console-template for more information

namespace branch
{
    internal class Program
    {
        public class Item
        {
            public float weight;
            public int value;
            public float cost;
            public int id;

            public Item(int weight, int value,int id )
            {
                this.weight = weight;
                this.value = value;
                this.cost = this.value / this.weight;
                this.id = id;
            }

            public Item()
            {

            }
            public static Item[] Sort(Item[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                    for (int j = i + 1; j < arr.Length - 1; j++)
                        if (arr[i].cost > arr[j].cost)
                        {
                            Item temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                return arr;
            }
        };


        // Node structure to store information of decision
        // tree
        public class Node
        {
            public int id;
            public Node left, right, parent;
            public List<Item> arr;

            public double upper;
            public double cost;

            public Node(List<Item> arr,int id)
            {
                this.arr = arr;
                left = right = null;
                this.id = id;
            }

            public void countUpper(int W)
            {
                double sum = 0;
                for(int i =0; i< arr.Count && sum < W;i++)
                {
                    upper += arr[i].value;
                    sum += arr[i].weight;
                }

                sum = 0;
                for(int i = 0;i < arr.Count && sum < W;i++)
                {
                    if (sum + arr[i].weight > W)
                    {
                        cost += arr[i].cost * (W - sum);
                    }
                    else
                        cost += arr[i].value;
                }    
            }


        }

            class BranchAndBound
        {
                public List<Item> solution;
            public int id;

                public BranchAndBound()
                {
                    solution = new List<Item>();
                }
                public static double sumWeight(List<Item> array)
            {
                double sum = 0;
                foreach(Item obj in array)
                {
                    sum += obj.weight;
                }
                return sum;
            }
            static public void dive(int n, Node root,int i, int W, List<Item> array, List<Item> arrayAll, double sumCurrent,int id)
                {
                // root.countUpper(W);
                if (i < n)
                {
                    if (sumCurrent + arrayAll[i].weight <= W)
                    {
                        //array.Add(arrayAll[i]);
                        List<Item> newArray = new List<Item>();
                        foreach (Item obj in root.arr)
                            newArray.Add(obj);
                        newArray.Add(arrayAll[i]);
                        root.left = new Node(newArray,id);
                        dive(n, root.left, i + 1, W, array, arrayAll, sumCurrent + arrayAll[i].weight, id+1);
                    }
/*                    else
                    {*/
                    //List<Item> tempArray = array;
                   // tempArray.RemoveAt(i);
                    root.right = new Node(root.arr,id + 1);
                    dive(n, root.right, i +1, W, array, arrayAll, sumCurrent, id + 1);
                   // }
                }

                   root.countUpper(W);
                   return;
                
                }
            public void findBest(Node root, ref double profit)
            {
                if (root == null)
                    return;
               // else if (root.left != null)
                    findBest(root.left, ref profit);
               // else if (root.right != null)
                    findBest(root.right, ref profit);

                if (root.upper > profit)
                {
                   
                    this.solution = root.arr;                
                    profit = root.upper;
                    this.id = root.id;
                }
                //return;

            }
            public void knapsack(int W, Item[] arr, int n)
            {
                    arr = Item.Sort(arr);
                    List<Item> array =  arr.ToList<Item>();
                    List<Item> arrayPust = new List<Item>();
                    Node root = new Node(arrayPust,0);
                    //for (int i = 0; i < arr.Length - 1;i++)
                   // {
                        dive(n, root, 0,W,arrayPust,array, 0,0);
                double profit = 0;
                findBest(root, ref profit);
                  //  }
            }

          
        }

        static void Main(string[] args)
        {
            Random weight = new Random();
            Random value = new Random();

            Item[] array = new Item[5];
            for (int i = 0; i < 5; i++)
                array[i] = new Item(weight.Next(1, 20), value.Next(1, 40),i);
            array = Item.Sort(array);
            foreach (Item obj in array)
                Console.WriteLine(obj.id + " Вес " + obj.weight + " Цена " + obj.value);

                BranchAndBound res = new BranchAndBound();
                res.knapsack(15, array, 5);
            Console.Write(res.id);
            Console.WriteLine("Решение ");
            double bestaPrice = 0;
            foreach (Item obj in res.solution)
            {
                Console.WriteLine(obj.id + " Вес " + obj.weight + " Ценность " + obj.value);
                bestaPrice += obj.value;
            }
            Console.WriteLine("Общая ценность " + bestaPrice);
                //Console.WriteLine(BranchAndBound.knapsack(15, array, 6)); //+ BranchAndBound.knapsack(15, array, 6).Item2);


        }
    }





}

/*
namespace BackpackTask
{
    internal class Program
    {
        public class Item
        {
            public double weight;
            public int value;
            public double cost;

            public Item(int weight, int value)
            {
                this.weight = weight;
                this.value = value;
                this.cost = this.value / this.weight;
            }

            public Item()
            {

            }
            public static Item[] Sort(Item[] arr )
            {
                for (int i = 0; i < arr.Length - 1; i++)
                    for (int j = i + 1; j < arr.Length - 1; j++)
                        if (arr[i].cost > arr[j].cost)
                        {
                            Item temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                return arr;
            }
        };
       
        public struct Info
        {
            public double upper_bound;
            public double cost;
            public string way;
            public char choise;
        };

        public class Node
        {
            public Info Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node()
            {

            }
            public Node(Info data)
            {
                this.Data = data;

            }
        }

        public class BinaryTree
        {
            public Node _root;
            public Node u;
            public BinaryTree()
            {
                _root = null;
                u = _root;
            }
            public Node Insert(Info data, char choise)
            {
                // 1. If the tree is empty, return a new, single node 
                if (_root == null)
                {
                    _root = new Node(data);
                    u = _root;
                }
                else
                // 2. Otherwise, recur down the tree 
                InsertRec(u, new Node(data), choise);
                return u;
            }

            public void InsertRec(Node u, Node newNode, char choise)
            {
                if (this.u == null)
                    this.u = newNode;

                if (choise == 'l') //root.Data.choise
                {
                    if (this.u.Left == null)
                    {
                        u.Left = newNode;
                        this.u = u.Left;
                    }

                    *//* else
                         InsertRec(root.Left, newNode, choise);*//*

                }
                else
                {
                    if (this.u.Right == null)
                    {
                        u.Right = newNode;
                        this.u = u.Right;
                    }

                    *//*else
                        InsertRec(root.Right, newNode, choise);*//*
                }
            }

        }

        // метод для решения задачи. Принимает максималный вес W, список предметов и количество предметов
        static public string knapsack(int W, Item[] arr, int n)
        {
            //List<Item> result = new List<Item>();
            string result = "";


            BinaryTree tree = new BinaryTree();
            Node root = new Node();
            Info l, r;
            Node v = root;
            double Profit = 0;

            for (int i = 0; i < n - 1; i++)
            {
                r.upper_bound = 0;
                r.cost = 0;
                r.choise = 'r';
                r.way = "";
                l.upper_bound = 0;
                l.cost = 0;
                l.choise = 'l';
                l.way = "";
                double mass = 0;
                double ost = 0;
                double sum = 0;

                //Берем i-й предмет (если его положить в рюкзак) и считаем для него верхнюю границу
                for (int x = i; x < n - 1; x++)
                {
                    mass += arr[x].weight;
                    if (mass < W)
                    {

                    }

                    else
                    {
                        mass -= arr[x].weight;
                        sum = 0;
                        for (int j = i; j < x; j++)
                        {
                            sum += arr[j].cost;
                        }
                        l.upper_bound = (-1) * sum;
                        if (l.upper_bound < Profit) Profit = l.upper_bound;

                        for (int h = x; h < n - 1; h++)
                        {
                            ost += (W - mass) * arr[h].cost / arr[h].weight;
                        }
                        l.cost = (sum + ost) * (-1);
                    }
                }

                //Если не возбмем i-й предмет                                      
                mass = 0;
                ost = 0;
                sum = 0;
                for (int x = i + 1; x < n - 1; x++)
                {
                    mass += arr[x].weight;
                    if (mass < W)
                    {

                    }

                    else
                    {
                        mass -= arr[x].weight;
                        sum = 0;
                        for (int j = i + 1; j < x; j++)
                        {
                            sum += arr[j].cost;
                        }
                        r.upper_bound = sum * (-1);
                        if (r.upper_bound <= Profit) Profit = r.upper_bound;

                        for (int h = x; h < n - 1; h++)
                        {
                            ost += (W - mass) * arr[h].cost / arr[h].weight;
                        }
                        r.cost = (sum + ost) * (-1);
                    }

                }

                //Выбор пути - берем предмет или нет                
                if (l.upper_bound < r.upper_bound && Profit >= l.upper_bound)
                {
                    l.way += '0';
                    tree.Insert(l, 'l');
                    Profit = l.upper_bound;
                }

                if (r.upper_bound < l.upper_bound && Profit >= r.upper_bound)
                {
                    r.way += '1';
                    tree.Insert(r, 'r');
                    Profit = r.upper_bound;
                }


            }

            //
            Info dummy;
            dummy.upper_bound = 0;
            dummy.cost = 0;
            dummy.choise = 'l';
            dummy.way = "";

            Node have = tree.Insert(dummy, 'l');

            string resu = have.Data.way;
            for (int z = 0; z < resu.Length; z++)
            {
               // if (resu[z] == '1') result.Add(arr[z]);
                if (resu[z] == '1') result += " " + arr[z];
            }
            return result;

        }
        static void Main(string[] args)
        {
            Random weight = new Random();
            Random value = new Random();

            //ItemsArray array = new ItemsArray(6);
            Item[] arr = new Item[6];
            for (int i = 0; i < 6; i++)
                arr[i] = new Item(weight.Next(1, 20), value.Next(1, 40));

            Item.Sort(arr);
            foreach (Item obj in arr)
                Console.WriteLine("Вес " + obj.weight + " Цена " + obj.value);


            Console.WriteLine(knapsack(15, arr, 6)); //+ BranchAndBound.knapsack(15, array, 6).Item2);


        }

    }
}*/