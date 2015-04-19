using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BO;

namespace Form1
{
    public partial class Form1 : Form
    {

        StudentBO sbo = new StudentBO();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Student st = new Student();
                st.roll = textBox1.Text;
                st.name = textBox2.Text;
                st.batch = textBox3.Text;
                st.year = comboBox1.Text;
                st.term = comboBox2.Text;
                st.adress = textBox4.Text;
                st.contact = textBox5.Text;
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                comboBox1.Text = null;
                comboBox2.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;

                sbo.keepStudentInfo(st);
                MessageBox.Show("Save Successfully");

            }
            catch (Exception e1)
            {

                MessageBox.Show("An Exception");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
