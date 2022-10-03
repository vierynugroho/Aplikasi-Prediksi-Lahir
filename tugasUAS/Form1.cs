using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasUAS
{
    public partial class Form1 : Form
    {
        public static DateTime dateNow;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            // Form 1
            Form1 form1 = new Form1();
            this.Hide();
            dateNow = dateTimePicker.Value;
            // Form 2
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
