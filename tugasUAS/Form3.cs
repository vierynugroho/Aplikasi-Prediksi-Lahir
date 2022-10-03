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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Hide();
            Form1 form1 = new Form1();
            form1.Hide();
            DateTime dateUpdate;
            dateUpdate = Form1.dateNow.AddDays(7).AddMonths(-3).AddYears(1);
            labelHasil.Text =  "Selamat Bunda!\n\n"+ "Bunda "+ Form2.nama + " Si Kecil Diperkirakan Lahir Pada: " + dateUpdate.ToString("dd-MM-yyyy");
        }

        private void labelHasil_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
