using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myProject
{
    public partial class picture : Form
    {
        public picture()
        {
            InitializeComponent();
            a1();
            m1 = new ask();
            m2 = new ask();
        }

        void a1()
        {
            DataTable dt = new DataTable();


            string[,] data = new string[9, 9];
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    data[i, j] = i.ToString() + "??" + j.ToString() + "=" + (i * j).ToString();
                }

            }
            for (int i = 0; i < 9; i++)
            {
                dt.Columns.Add(i.ToString());
            }

            for (int i = 0; i < 9; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < 9; j++)
                {
                    row[j] = data[i, j];
                }
                dt.Rows.Add(row);  // 添加这一行
            }

            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersVisible = false;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
            textBox1.Text = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < 9; i++)
            {
                dt.Columns.Add(i.ToString()+"1");
            }
            m1.dataGridView1.DataSource = dt;
            m1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < 9; i++)
            {
                dt.Columns.Add(i.ToString() + " xi            ai");
            }
            m2.dataGridView1.DataSource = dt;
            m2.ShowDialog();
        }
    }
}
