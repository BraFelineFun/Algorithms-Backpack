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
    public partial class ChooseAction : Form
    {
        static public Form1 Form1 { get; private set; }
        static public Autotests Autotests { get; private set; }
        public ChooseAction()
        {
            InitializeComponent();
        }

        private void button_manual_Click(object sender, EventArgs e)
        {
            Form1 = new Form1();
            Form1.ShowDialog(this);
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            Autotests = new Autotests();
            Autotests.ShowDialog(this);
        }
    }
}
