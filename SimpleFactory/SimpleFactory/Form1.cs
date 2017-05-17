using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation oper = OperationFactory.CreateOperation("+");

            oper.NumberA = 1;
            oper.NumberB = 2;

            MessageBox.Show(oper.GetResult().ToString());
        }
    }
}
