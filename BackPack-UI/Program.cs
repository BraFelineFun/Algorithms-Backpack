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
        public static bool IsInitialized { 
            get{ return backPack != null && items.Length > 0; } 
        }


        public static void CreateBackpack(string capacity)
        {
            int intCapacity;
            try
            {
                intCapacity = Convert.ToInt32(capacity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            backPack = new BackPack(intCapacity);
            Program.Form_main.AddBackPack(backPack);
        }
        public static void AddItem(int weight, int cost)
        {
            Item item = new Item(weight, cost);
            items.Add(new Item(weight, cost));
            Program.Form_main.AddItem(item);
        }
        public static string getSimpleSolution(bool getEvaluationTime)
        {
            EvaluationTimer timer = new EvaluationTimer();
            timer.StartCount();
            string solution = "Simple solution: \n" + SimpleSolver.Solve(items, backPack).ToString();
            string evaluationTime = timer.StopCount();

            if (getEvaluationTime)
                solution = evaluationTime + solution;

            return solution;
        }
        public static string getBranchSolution(bool getEvaluationTime)
        {
            EvaluationTimer timer = new EvaluationTimer();
            timer.StartCount();
            string solution = "\nBranch solution: \n" + BranchAndBound.Solve(items, backPack.GetCapacity()).ToString();

            string evaluationTime = timer.StopCount();
            if (getEvaluationTime)
                solution = evaluationTime + solution;

            return solution;
        }
    }
}