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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            StudentBO ss = new StudentBO();

            Student[] st = new Student[60];
            st = ss.getStudentinfo();

            for (int i = 0; ; i++)
            {

                if (st[i] == null)
                    break;

                dataGridView1.Rows.Add(st[i].roll, st[i].name, st[i].batch, st[i].year, st[i].term, st[i].adress, st[i].contact);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
