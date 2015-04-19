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

namespace UI
{
    public partial class Form1 : Form
    {
        StudentBO sbo = new StudentBO();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = null;
            comboBox2.Text = null;
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

                sbo.keepStudentInfo(st);
            }
            catch (Exception e1)
            {
                MessageBox.Show("R u Kidding");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Save Successfully");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
