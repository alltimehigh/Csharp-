using System.Data;
using System.Windows.Forms;

namespace myProject
{
    public partial class Form1 : Form
    {
        private int i1 = 0, j1 = 0;
        public Form1()
        {
            InitializeComponent();
            doc = new picture();
            a2();
            block();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc.ShowDialog();
        }

        private void 点位图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(123);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Taikoo";
            a1();
            a3();

        }
        void a()
        {
            DataTable dt = new DataTable();

            // 创建列
            for (int j = 0; j < 5; j++)
            {
                dt.Columns.Add("点" + (j + 1), typeof(double));
            }

            // 添加行数据
            for (int i = 0; i < 5; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < 5; j++)
                {
                    row[j] = j;
                }
                dt.Rows.Add(row);
            }

            // 绑定到 DataGridView
            dataGridView1.DataSource = dt;
        }

        void a1()
        {
            DataTable dt = new DataTable();
            string a = "123";
            int num2 = Convert.ToInt32(a);
            listBox1.Items.Add(num2);

            string[,] data = new string[9, 9];
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    data[i, j] = i.ToString() + "*" + j.ToString() + "=" + (i * j).ToString();
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

        void a2()
        {
            DataTable dt = new DataTable();


            string[,] data = new string[9, 9];
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    data[i, j] = i.ToString() + "./" + j.ToString() + "=" + (i * j).ToString();
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

            dataGridView2.DataSource = dt;
            dataGridView2.ColumnHeadersVisible = false;
        }

        void block()
        {
            dataGridView3.RowCount = 6;
            dataGridView3.ColumnCount = 6;

            for (int i = 0; i < 6; i++)
            {
                dataGridView3.Columns[i].Width = 50;
                dataGridView3.Rows[i].Height = 50;
            }

            // 初始化所有格子
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    // 设置格子样式
                    dataGridView3[j, i].Style.BackColor = Color.DimGray;
                    dataGridView3[j, i].Style.ForeColor = Color.White;

                }
            }
            dataGridView3[0, 0].Style.BackColor = Color.Blue;
            dataGridView3[0, 0].Style.ForeColor = Color.White;
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (j1 > 0) j1--;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    // 设置格子样式
                    dataGridView3[j, i].Style.BackColor = Color.DimGray;
                    dataGridView3[j, i].Style.ForeColor = Color.White;

                }
            }
            dataGridView3[i1, j1].Style.BackColor = Color.Blue;
            dataGridView3[i1, j1].Style.ForeColor = Color.White;
        }

        void a3()
        {
            a4(a5());
        }
        int[] a5()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            return a;
        }
        void a4(params int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                label1.Text += a[i].ToString();
        }
        private void down_Click(object sender, EventArgs e)
        {
            if (j1 < 5) j1++;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    // 设置格子样式
                    dataGridView3[j, i].Style.BackColor = Color.DimGray;
                    dataGridView3[j, i].Style.ForeColor = Color.White;

                }
            }
            dataGridView3[i1, j1].Style.BackColor = Color.Blue;
            dataGridView3[i1, j1].Style.ForeColor = Color.White;
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (i1 > 0) i1--;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    // 设置格子样式
                    dataGridView3[j, i].Style.BackColor = Color.DimGray;
                    dataGridView3[j, i].Style.ForeColor = Color.White;

                }
            }
            dataGridView3[i1, j1].Style.BackColor = Color.Blue;
            dataGridView3[i1, j1].Style.ForeColor = Color.White;
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (i1 < 5) i1++;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    // 设置格子样式
                    dataGridView3[j, i].Style.BackColor = Color.DimGray;
                    dataGridView3[j, i].Style.ForeColor = Color.White;
                }
            }

            dataGridView3[i1, j1].Style.BackColor = Color.Blue;
            dataGridView3[i1, j1].Style.ForeColor = Color.White;
        }

     
    }


}
