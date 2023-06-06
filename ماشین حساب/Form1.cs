using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ماشین_حساب
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double num1=Convert.ToDouble(textBox1.Text);
           double num2=Convert.ToDouble(textBox2.Text);
            lbl_result.Text =Convert.ToString( num1 + num2);
        }

        private void btn_mines_Click(object sender, EventArgs e)
        {
            double num1= Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            lbl_result.Text=Convert.ToString(num1 - num2);

        }

        private void btn_multiplay_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            lbl_result.Text = Convert.ToString(num1 * num2);
        }

        private void btn_devide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            lbl_result.Text = Convert.ToString(num1 / num2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
           a= MessageBox.Show("do you want to exit ? ", "exit", MessageBoxButtons.YesNo);
            if(a== DialogResult.Yes)
                Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lbl_result.Text = "";

        }
    }
}
