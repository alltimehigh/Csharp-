namespace myProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            点位图ToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            up = new Button();
            down = new Button();
            left = new Button();
            right = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 点位图ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1148, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            文件ToolStripMenuItem.Click += 文件ToolStripMenuItem_Click;
            // 
            // 点位图ToolStripMenuItem
            // 
            点位图ToolStripMenuItem.Name = "点位图ToolStripMenuItem";
            点位图ToolStripMenuItem.Size = new Size(56, 21);
            点位图ToolStripMenuItem.Text = "点位图";
            点位图ToolStripMenuItem.Click += 点位图ToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(34, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(79, 21);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(331, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(693, 313);
            dataGridView1.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(34, 86);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 352);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(717, 322);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(717, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(705, 313);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.Control;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(781, 118);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(355, 333);
            dataGridView3.TabIndex = 6;
            // 
            // up
            // 
            up.Location = new Point(420, 449);
            up.Name = "up";
            up.Size = new Size(75, 23);
            up.TabIndex = 7;
            up.Text = "up";
            up.UseVisualStyleBackColor = true;
            up.Click += up_Click;
            // 
            // down
            // 
            down.Location = new Point(420, 503);
            down.Name = "down";
            down.Size = new Size(75, 23);
            down.TabIndex = 7;
            down.Text = "down";
            down.UseVisualStyleBackColor = true;
            down.Click += down_Click;
            // 
            // left
            // 
            left.Location = new Point(331, 475);
            left.Name = "left";
            left.Size = new Size(75, 23);
            left.TabIndex = 7;
            left.Text = "left";
            left.UseVisualStyleBackColor = true;
            left.Click += left_Click;
            // 
            // right
            // 
            right.Location = new Point(512, 475);
            right.Name = "right";
            right.Size = new Size(75, 23);
            right.TabIndex = 7;
            right.Text = "right";
            right.UseVisualStyleBackColor = true;
            right.Click += right_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(790, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 561);
            Controls.Add(label1);
            Controls.Add(down);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(up);
            Controls.Add(dataGridView3);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 点位图ToolStripMenuItem;
        private picture doc;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button up;
        private Button down;
        private Button left;
        private Button right;
        private Label label1;
    }
}
