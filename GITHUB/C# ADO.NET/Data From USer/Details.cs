using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string empName, empID, pno, country, gender, a1, a2, a3;
        bool phtml = false;
        bool psql = false;
        bool pc = false;
        int i = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            empName = textBox1.Text;
            for (i = 0; i < 2; i++)
            {
                progressBar1.Value = i * 20;
            }

        }
        
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            empID = textBox2.Text;
            for (i = 0; i < 3; i++)
            {
                progressBar1.Value = i * 20;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pno = textBox3.Text;
            for (i = 0; i < 4; i++)
            {
                progressBar1.Value = i * 20;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("India");
            comboBox1.Items.Add("Canada");
            comboBox1.Items.Add("USA");
            country = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            for (i = 0; i < 5; i++)
            {
                progressBar1.Value = i * 20;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            phtml = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            psql = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pc = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            a1 = textBox4.Text;
            for (i = 0; i < 6; i++)
            {
                progressBar1.Value = i * 20;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            a2 = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            a3 = textBox6.Text;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your data has been recorded");
        }
    }
}
