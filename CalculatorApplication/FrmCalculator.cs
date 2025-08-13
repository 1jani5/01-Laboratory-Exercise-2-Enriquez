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

        CalculatorClass cal;
        double num1, num2;

        public FrmCalculator()
        {
            InitializeComponent();

            cal = new CalculatorClass();


            panel1.BackColor = Color.FromArgb(100, Color.BurlyWood);
            panel2.BackColor = Color.FromArgb(100, Color.BurlyWood);
            panel3.BackColor = Color.FromArgb(100, Color.BurlyWood);

            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                if (comboBox1.Text == "+")
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetSum);
                    textBox3.Text = CalculatorClass.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetSum);
                }
                else if (comboBox1.Text == "-")
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetDifference);
                    textBox3.Text = CalculatorClass.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetDifference);
                }
                else if (comboBox1.Text == "*")
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetProduct);
                    textBox3.Text = CalculatorClass.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetProduct);
                }
                else if (comboBox1.Text == "/")
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetQoutient);
                    textBox3.Text = CalculatorClass.GetQoutient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetQoutient);
                }
                else
                {
                    MessageBox.Show("Please select a valid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }
    



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
