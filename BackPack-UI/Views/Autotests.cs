using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackPack_UI
{
    struct ResultStructure
    {
        public int cost;
        public EvaluationTimer evalTime;
    }
    struct Methods
    {
        public ResultStructure Simple;
        public ResultStructure Branches;
    }


    public partial class Autotests : Form
    {
        Controller Controller;
        List<Methods> results;

        public Autotests()
        {
            InitializeComponent();
            results = new List<Methods>();
        }

        private string GetStatistics()
        {
            string statistics =  "";
            int rightAns = 0;
            double resultTimeBranches = 0;
            double resultTimeSimple = 0;

            foreach (Methods result in results)
            {
                rightAns = result.Branches.cost == result.Simple.cost ? rightAns + 1 : rightAns;
                resultTimeBranches += result.Branches.evalTime.Time.TotalMilliseconds;
                resultTimeSimple += result.Simple.evalTime.Time.TotalMilliseconds;
            }
            if (resultTimeBranches == 0) resultTimeBranches = 1;
            if (resultTimeSimple == 0) resultTimeSimple = 1;

            double otkl = Math.Abs(resultTimeBranches - resultTimeSimple) / resultTimeSimple;

            statistics += "СТАТИСТИКА:";
            statistics += "\nПроцент совпавших ответов = " + rightAns / results.Count * 100 + "%";
            statistics += "\nСреднее относительное отклонение приближенного решения от точного по времени = " + otkl;
            return statistics;
        }

        private void GetSolution(string filename)
        {
            Methods methods = new Methods();
            methods.Simple = new ResultStructure();
            methods.Branches = new ResultStructure();

            Controller = new Controller(false);
            ImportParameters.ReadFile(Controller, filename);

            ReturnStructure solution1 = Controller.GetSimpleSolution(true);
            methods.Simple.evalTime = solution1.Time;
            methods.Simple.cost = solution1.BackPack.currentCost;

            ReturnStructure solution2 = Controller.GetBranchSolution(true);
            methods.Branches.evalTime = solution2.Time;
            methods.Branches.cost = solution2.BackPack.currentCost;

            results.Add(methods);

            string solution = "Type = " + solution1.SolutionType + "; Time = " + solution1.Time + "; Cost = " + solution1.BackPack.currentCost.ToString() + "; Weight = " + solution1.BackPack.currentWeight.ToString() +
                "\n" + "Type = " + solution2.SolutionType + "; Time = " + solution2.Time + "; Cost = " + solution2.BackPack.currentCost.ToString() + "; Weight = " + solution2.BackPack.currentWeight.ToString();


            SolutionLabel solutionLabel = new SolutionLabel(solution, filename)
            {
                BackColor = SystemColors.ButtonFace,
                MinimumSize = new Size(400, 75)
            };

            FLP_result.Controls.Add(solutionLabel);
        }

        public void GetSolutionsGenerate()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/source/";

            for (int i = 0; i < Convert.ToInt32(textBox_Tests.Text); i++)
            {
                string file = Convert.ToString(i) + ".txt";
                GetSolution(projectDirectory + file);
            }
        }

        private void GetSolutionsFromFile()
        {
            var fileNames = ImportParameters.ChooseFiles(true);
                if (fileNames == null) return;
            foreach (var file in fileNames)
                GetSolution(file);
        }

        private void GetSolutions(bool isFile = false)
        {
            if (isFile)
                GetSolutionsFromFile();
            else
                GetSolutionsGenerate();

            SolutionLabel statisticLabel = new SolutionLabel(GetStatistics(), "label_statistic")
            {
                BackColor = System.Drawing.Color.Maroon,
                ForeColor = System.Drawing.Color.White,
                MinimumSize = new Size(400, 75)
            };
            FLP_result.Controls.Add(statisticLabel);
        }

        private void button_get_test_Click(object sender, EventArgs e)
        {
            bool isFilled = textBox_Vmax.Text != "" && textBox_Tests.Text != "" && textBox_capacity.Text != "";
            if (!isFilled)
            {
                MessageBox.Show("Пожалуйста, заполните поля", "Пожалуйста, заполните поля", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < Convert.ToInt32(textBox_Tests.Text); i++)
            {
                ItemList itemList = new ItemList();
                for (int j = 0; j < Convert.ToInt32(textBox_Vmax.Text); j++)
                {
                    (int, int) item = RandomItem.GetRItem(Convert.ToInt32(textBox_capacity.Text));
                    itemList.Add(new Item(item.Item1, item.Item2));
                }
                ImportParameters.WriteFile(Controller, i.ToString() + ".txt", Convert.ToInt32(textBox_capacity.Text), itemList);
            }
            GetSolutions();
        }

        private void button_getFromFiles_Click(object sender, EventArgs e)
        {
            GetSolutions(true);
        }
    }
}
