using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack_UI
{
    internal class ImportParameters
    {
        public static string[]? ChooseFiles(bool isMultiple)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Файл исходник";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Multiselect = isMultiple;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Не выбран ни один файл", "Пожалуйста, выберете файл");
                return null;
            }
            return openFileDialog.FileNames;
        }

        public static void ReadFile(Controller controller, string filename)
        {
            StreamReader file = new StreamReader(filename);

            string currentLine = file.ReadLine();

            if (currentLine == "" || currentLine == null)
            {
                MessageBox.Show("Ошибка", "Ошибка чтения файла");
                return;
            }

            controller.CreateBackpack(currentLine);

            while (!file.EndOfStream)
            {
                currentLine = file.ReadLine();
                string[] tempArray = currentLine.Split(' ');

                int weight = Convert.ToInt32(tempArray[0]);
                int cost = Convert.ToInt32(tempArray[1]);

                controller.AddItem(weight, cost);
            }
            file.Close();
        }

        public static void Import(Controller controller)
        {
            var fn = ChooseFiles(false);
            if (fn == null) return;
            string sFileName = fn[0];

            ReadFile(controller, sFileName);
        }

    }
}
