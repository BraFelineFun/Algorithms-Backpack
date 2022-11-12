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
        public void AddBackPack(BackPack backPack)
        {
            createBackpack_button.Text = "�������� ������";
            textBox_backpackCapacity.Text = backPack.GetCapacity().ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            formAdd.ShowDialog(this);
        }

        private void createBackpack_button_Click(object sender, EventArgs e)
        {
            Controller.CreateBackpack(textBox_backpackCapacity.Text);
        }

        private void button_solution_Click(object sender, EventArgs e)
        {
            if (!Controller.IsInitialized)
            {
                MessageBox.Show("����������, ������� ��������� ������� � �����", "������", MessageBoxButtons.OK);
                return;
            }

            Button btn = sender as Button;
            btn.Enabled = false;
            

            string solution1 = Controller.getSimpleSolution(true);

            string solution2 = Controller.getBranchSolution(true);


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

            btn.Enabled = true;
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            ImportParameters.Import();
        }
    }
}