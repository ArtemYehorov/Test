using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form2 : Form
    {
        Form1 parent;
        private string data = "";
        public string Data
        {
            get => data;
            set
            {
                data = value;
                textBox1.Text = data;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 par)
        {
            InitializeComponent();
            parent = par;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            parent.Data = textBox1.Text;
        }
    }
}
