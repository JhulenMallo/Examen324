using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            dataGridView1.DataSource = sw.GET().Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            sw.DELETE(Int32.Parse(textBox1Delete.Text));
            dataGridView1.DataSource = sw.GET().Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //agregar
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            sw.INSERT(Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            dataGridView1.DataSource = sw.GET().Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //editar
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            sw.UPDATE(Int32.Parse(textBox5.Text), Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            dataGridView1.DataSource = sw.GET().Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
