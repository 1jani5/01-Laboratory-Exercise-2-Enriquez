using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.BurlyWood);
            panel2.BackColor = Color.FromArgb(100, Color.BurlyWood);
            panel3.BackColor = Color.FromArgb(100, Color.BurlyWood);

            comboBox1.Items.AddRange(new String[]
            {
                "+",
                "-",
                "*",
                "/"
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
