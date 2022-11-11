namespace BackPack_UI
{
    public static class Program
    {
        public static Form1 Form_main = new Form1();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(Form_main);
        }
    }

    public static class Controller
    {
        static ItemList items = new ItemList();
        static BackPack backPack;

        public static void CreateBackpack(int capacity)
        {
            backPack = new BackPack(capacity);
        }
        public static void AddItem(int weight, int cost)
        {
            Item item = new Item(weight, cost);
            items.Add(new Item(weight, cost));
            Program.Form_main.AddItem(item);
        }
        public static string getSimpleSolution()
        {
            string solution = "Simple solution: \n" + SimpleSolver.Solve(items, backPack).ToString();
            return solution;
        }
        public static string getBranchSolution()
        {
            string solution = "\nBranch solution: \n" + BranchAndBound.Solve(items, backPack.GetCapacity()).ToString();
            return solution;
        }
    }
}