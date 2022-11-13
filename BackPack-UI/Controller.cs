using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack_UI
{
    public class ReturnStructure
    {
        public string SolutionType;
        public BackPack BackPack;
        public EvaluationTimer Time;

        public ReturnStructure(string SolutionType, BackPack BackPack, EvaluationTimer Time)
        {
            this.SolutionType = SolutionType;
            this.BackPack = BackPack;
            this.Time = Time;
        }

        public override string ToString()
        {
            string solution = "\n" + SolutionType + ": \n" + BackPack.ToString();
            if (Time != null)
                solution = Time.ToString() + solution;

            return solution;
        }
    }


    public class Controller
    {


        ItemList items;
        BackPack backPack;
        bool isManual;

        public bool IsInitialized
        {
            get { return backPack != null && items.Length > 0; }
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
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
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

        public ReturnStructure GetSimpleSolution(bool getEvaluationTime)
        {
            string SolutionType = "SimpleSolution";
            EvaluationTimer timer = new EvaluationTimer();
            timer.StartCount();
            BackPack BackPack = SimpleSolver.Solve(items, backPack);
            timer.StopCount();


            ReturnStructure rs = new ReturnStructure(SolutionType, BackPack, timer);


            return rs;
        }
        public ReturnStructure GetBranchSolution(bool getEvaluationTime)
        {
            string SolutionType = "BranchSolution";
            EvaluationTimer timer = new EvaluationTimer();
            timer.StartCount();
            BackPack BackPack = BranchAndBound.Solve(items, backPack.GetCapacity());
            timer.StopCount();


            ReturnStructure rs = new ReturnStructure(SolutionType, BackPack, timer);


            return rs;
        }
    }
}
