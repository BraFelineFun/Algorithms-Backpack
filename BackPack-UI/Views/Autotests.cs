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

            //Thread t = new Thread(() => GetSolutions());
            //t.Start();
            GetSolutions();
        }

        public void GetSolutions()
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
    }
}
