namespace dict
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColEnglish = new DataGridViewTextBoxColumn();
            ColMongolian = new DataGridViewTextBoxColumn();
            ColRussian = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lstSaved = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(763, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Гурван хэлний толь бичиг";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(529, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "Хайх үг ...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Хайх :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 63);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 3;
            label2.Text = "Хэл :";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(658, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 33);
            comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, ColEnglish, ColMongolian, ColRussian });
            dataGridView1.Location = new Point(18, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(494, 299);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // ColEnglish
            // 
            ColEnglish.HeaderText = "Англи";
            ColEnglish.MinimumWidth = 8;
            ColEnglish.Name = "ColEnglish";
            ColEnglish.ReadOnly = true;
            // 
            // ColMongolian
            // 
            ColMongolian.HeaderText = "Монгол";
            ColMongolian.MinimumWidth = 8;
            ColMongolian.Name = "ColMongolian";
            ColMongolian.ReadOnly = true;
            // 
            // ColRussian
            // 
            ColRussian.HeaderText = "Орос";
            ColRussian.MinimumWidth = 8;
            ColRussian.Name = "ColRussian";
            ColRussian.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Location = new Point(553, 110);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 6;
            label3.Text = "Санасан үгс :";
            // 
            // lstSaved
            // 
            lstSaved.FormattingEnabled = true;
            lstSaved.Location = new Point(553, 138);
            lstSaved.Name = "lstSaved";
            lstSaved.Size = new Size(222, 254);
            lstSaved.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(12, 485);
            button1.Name = "button1";
            button1.Size = new Size(173, 34);
            button1.TabIndex = 8;
            button1.Text = "Нэмэх";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(201, 485);
            button2.Name = "button2";
            button2.Size = new Size(134, 34);
            button2.TabIndex = 9;
            button2.Text = "Засах";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(354, 485);
            button3.Name = "button3";
            button3.Size = new Size(134, 34);
            button3.TabIndex = 10;
            button3.Text = "Устгах";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(510, 485);
            button4.Name = "button4";
            button4.Size = new Size(134, 34);
            button4.TabIndex = 11;
            button4.Text = "Цэвэрлэх";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Aquamarine;
            button5.Location = new Point(650, 485);
            button5.Name = "button5";
            button5.Size = new Size(120, 34);
            button5.TabIndex = 12;
            button5.Text = "Санах";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 437);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 13;
            label4.Text = "Англи :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 437);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 14;
            label5.Text = "Монгол :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 437);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 15;
            label6.Text = "Орос :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 434);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 31);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(354, 434);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 31);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(603, 434);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 31);
            textBox5.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 531);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstSaved);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private ListBox lstSaved;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColEnglish;
        private DataGridViewTextBoxColumn ColMongolian;
        private DataGridViewTextBoxColumn ColRussian;
    }
}
