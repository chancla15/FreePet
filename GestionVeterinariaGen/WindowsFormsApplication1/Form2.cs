using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form1 f1 = new Form1();
            f1.Activate();
            f1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.Activate();
            f3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.Activate();
            f3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
