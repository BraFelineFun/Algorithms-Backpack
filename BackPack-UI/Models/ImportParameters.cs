using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack_UI
{
    internal class ImportParameters
    {
        public static void Import()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Файл исходник";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Не выбран файл", "Пожалуйста, выберете файл");
                return;
            }


            string sFileName = openFileDialog.FileName;
            StreamReader file = new StreamReader(sFileName);

            string currentLine = file.ReadLine();

            if (currentLine == "" || currentLine == null)
            {
                MessageBox.Show("Ошибка", "Ошибка чтения файла");
                return;
            }

            Controller.CreateBackpack(currentLine);

            while (!file.EndOfStream)
            {
                currentLine = file.ReadLine();
                string[] tempArray = currentLine.Split(' ');

                int weight = Convert.ToInt32(tempArray[0]);
                int cost = Convert.ToInt32(tempArray[1]);

                Controller.AddItem(weight, cost);
            }
            file.Close();
        }

    }
}
