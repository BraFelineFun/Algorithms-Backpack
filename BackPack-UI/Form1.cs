using System.Diagnostics;

namespace BackPack_UI
{
    public partial class Form1 : Form
    {
        Form_AddItem formAdd;

        public Form1()
        {
            formAdd = new Form_AddItem();
            InitializeComponent();
        }

        private void AddThingLabel(string text)
        {
            int index = flowLayoutPanel1.Controls.Count + 1;


            Label thingLabel = new Label();
            thingLabel.AutoSize = true;
            thingLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            thingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            thingLabel.Location = new System.Drawing.Point(13, 10);
            thingLabel.MaximumSize = new System.Drawing.Size(399, 1000);
            thingLabel.Name = "label_type";
            thingLabel.Padding = new System.Windows.Forms.Padding(5);
            thingLabel.Margin = new System.Windows.Forms.Padding(5);
            thingLabel.Text = Convert.ToString(index)+". " + text;

            flowLayoutPanel1.Controls.Add(thingLabel);
        }
        public void AddItem(Item item)
        {
            label_itemCount.Text = Convert.ToString(Convert.ToInt32(label_itemCount.Text) + 1);
            AddThingLabel(item.ToString());
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            formAdd.ShowDialog(this);
        }

        private void createBackpack_button_Click(object sender, EventArgs e)
        {
            int capacity;
            try
            {
                capacity = Convert.ToInt32(textBox_backpackCapacity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            createBackpack_button.Text = "Изменить рюкзак";
            Controller.CreateBackpack(capacity);
        }

        private void button_solution_Click(object sender, EventArgs e)
        {
            string elapsedTime;
            TimeSpan ts;

            Stopwatch stopWatchTwo = new Stopwatch();
            stopWatchTwo.Start();
            string solution1 = Controller.getSimpleSolution();
            stopWatchTwo.Stop();
            ts = stopWatchTwo.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            //Console.WriteLine("RunTime " + elapsedTime);
            solution1 = "\nRunTime" + elapsedTime + "\n" + solution1;

            stopWatchTwo.Restart();
            string solution2 = Controller.getBranchSolution();
            stopWatchTwo.Stop();
            ts = stopWatchTwo.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            solution2 = "\nRunTime" + elapsedTime + "\n" + solution2 +"\n\n\n";

            Label thingLabel = new Label();
            thingLabel.AutoSize = true;
            thingLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            thingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            thingLabel.MaximumSize = new System.Drawing.Size(736, 1000);
            thingLabel.Name = "label_type";
            thingLabel.Padding = new System.Windows.Forms.Padding(5);
            thingLabel.Margin = new System.Windows.Forms.Padding(5);
            thingLabel.Text = solution1 + solution2;

            FLP_answer.Controls.Add(thingLabel);
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            string sFileName = "";

            OpenFileDialog openFileDialog = new OpenFileDialog(); // Открываем файл с ексел 
            openFileDialog.Title = "Файл исходник";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string temp = "";
                sFileName = openFileDialog.FileName;
                StreamReader file = new StreamReader(sFileName);

                temp = file.ReadLine();
                textBox_backpackCapacity.Text = temp;

                while (!file.EndOfStream)
                {
                    temp = file.ReadLine();
                    string[] tempArray = temp.Split(' ');

                    int weight = Convert.ToInt32(tempArray[0]);
                    int cost = Convert.ToInt32(tempArray[1]);

                    Controller.AddItem(weight, cost);
                }
                file.Close();
            }
            else
            {
                MessageBox.Show(this, "Не выбран файл", "Пожалуйста, выберете файл");
            }
        }
    }
}