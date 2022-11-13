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
    public partial class Autotests : Form
    {
        Controller Controller;
        public Autotests()
        {
            InitializeComponent();
        }

        public void GetSolutions()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/source/";

            for (int i = 0; i < Convert.ToInt32(textBox_Tests.Text); i++)
            {
                string file = Convert.ToString(i) + ".txt";
                Controller = new Controller(false);
                ImportParameters.ReadFile(Controller, projectDirectory + file);

                ReturnStructure solution1 = Controller.GetSimpleSolution(true);

                ReturnStructure solution2 = Controller.GetBranchSolution(true);

                string solution = "Type = " + solution1.SolutionType + "; Time = " + solution1.Time + "; Cost = " + solution1.BackPack.currentCost.ToString() + "; Weight = " + solution1.BackPack.currentWeight.ToString() +
                    "\n" + "Type = " + solution2.SolutionType + "; Time = " + solution2.Time + "; Cost = " + solution2.BackPack.currentCost.ToString() + "; Weight = " + solution2.BackPack.currentWeight.ToString();


                SolutionLabel solutionLabel = new SolutionLabel(solution, file);
                solutionLabel.BackColor = SystemColors.ButtonFace;
                solutionLabel.MinimumSize = new Size(400, 75);

                FLP_result.Controls.Add(solutionLabel);
            }
        }

        private void GetSolutionsFromFile()
        {
            var fileNames = ImportParameters.ChooseFiles(true);
                if (fileNames == null) return;
            foreach (var file in fileNames)
            {
                Controller = new Controller(false);
                ImportParameters.ReadFile(Controller, file);

                ReturnStructure solution1 = Controller.GetSimpleSolution(true);

                ReturnStructure solution2 = Controller.GetBranchSolution(true);

                string solution = "Type = " + solution1.SolutionType + "; Time = " + solution1.Time + "; Cost = " + solution1.BackPack.currentCost.ToString() + "; Weight = " + solution1.BackPack.currentWeight.ToString() +
                    "\n" + "Type = " + solution2.SolutionType + "; Time = " + solution2.Time + "; Cost = " + solution2.BackPack.currentCost.ToString() + "; Weight = " + solution2.BackPack.currentWeight.ToString();


                SolutionLabel solutionLabel = new SolutionLabel(solution, file);
                solutionLabel.BackColor = SystemColors.ButtonFace;
                solutionLabel.MinimumSize = new Size(400, 75);

                FLP_result.Controls.Add(solutionLabel);
            }
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
            GetSolutionsFromFile();
        }
    }
}
