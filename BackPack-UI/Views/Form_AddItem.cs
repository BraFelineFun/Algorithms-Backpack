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
    public partial class Form_AddItem : Form
    {
        public Form_AddItem()
        {
            InitializeComponent();
        }

        private void textBox_weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addThing_Click(object sender, EventArgs e)
        {
            int cost, weight;
            try
            {
                weight = Convert.ToInt32(textBox_weight.Text);
                cost = Convert.ToInt32(textBox_cost.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            textBox_weight.Text = "";
            textBox_cost.Text = "";

            Program.Form_main.controller.AddItem(weight, cost);

            Close();
        }
    }
}
