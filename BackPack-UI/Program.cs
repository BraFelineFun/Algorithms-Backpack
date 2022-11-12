namespace BackPack_UI
{
    public static class Program
    {
        public static ChooseAction ChooseAction = new ChooseAction();
        public static Form1 Form_main 
        {
            get{ return ChooseAction.Form1; }
        }
       

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ChooseAction);
        }
    }

    public class ReturnStructure
    {
        public string SolutionType;
        public BackPack BackPack;
        public string? Time;

        public ReturnStructure(string SolutionType, BackPack BackPack, string Time = null)
        {
            this.SolutionType = SolutionType;
            this.BackPack = BackPack;
            this.Time = Time;
        }

        public string ToString()
        {
            string solution = "\n" + SolutionType + ": \n" + BackPack.ToString();
            if (Time != null)
                solution = Time + solution;

            return solution;
        }
    }

    public class Controller
    {


        ItemList items;
        BackPack backPack;
        bool isManual;

        public bool IsInitialized { 
            get{ return backPack != null && items.Length > 0; } 
        }

        public Controller(bool isManual)
        {
            this.isManual = isManual;
            items = new ItemList();
        }


        public void CreateBackpack(string capacity)
        {
            int intCapacity;
            try
            {
                intCapacity = Convert.ToInt32(capacity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Œ¯Ë·Í‡", MessageBoxButtons.OK);
                return;
            }

            backPack = new BackPack(intCapacity);

            if (isManual)
                Program.Form_main.AddBackPack(backPack);
        }
        public void AddItem(int weight, int cost)
        {
            Item item = new Item(weight, cost);
            items.Add(new Item(weight, cost));

            if (isManual)
                Program.Form_main.AddItem(item);
        }
        //public string GetSimpleSolution(bool getEvaluationTime)
        //{
        //    EvaluationTimer timer = new EvaluationTimer();
        //    timer.StartCount();
        //    string solution = "Simple solution: \n" + SimpleSolver.Solve(items, backPack).ToString();
        //    string evaluationTime = timer.StopCount();

        //    if (getEvaluationTime)
        //        solution = evaluationTime + solution;

        //    return solution;
        //}
        //public string GetBranchSolution(bool getEvaluationTime)
        //{
        //    EvaluationTimer timer = new EvaluationTimer();
        //    timer.StartCount();
        //    string solution = "\nBranch solution: \n" + BranchAndBound.Solve(items, backPack.GetCapacity()).ToString();

        //    string evaluationTime = timer.StopCount();
        //    if (getEvaluationTime)
        //        solution = evaluationTime + solution;

        //    return solution;
        //}

        public ReturnStructure GetSimpleSolution(bool getEvaluationTime)
        {
            string SolutionType = "SimpleSolution";
            EvaluationTimer timer = new EvaluationTimer();
            timer.StartCount();
            BackPack BackPack = SimpleSolver.Solve(items, backPack);
            string evaluationTime = timer.StopCount();


            ReturnStructure rs = new ReturnStructure(SolutionType, BackPack, evaluationTime);


            return rs;
        }
        public ReturnStructure GetBranchSolution(bool getEvaluationTime)
        {
            string SolutionType = "BranchSolution";
            EvaluationTimer timer = new EvaluationTimer();
            timer.StartCount();
            BackPack BackPack = BranchAndBound.Solve(items, backPack.GetCapacity());
            string evaluationTime = timer.StopCount();


            ReturnStructure rs = new ReturnStructure(SolutionType, BackPack, evaluationTime);


            return rs;
        }
    }

}