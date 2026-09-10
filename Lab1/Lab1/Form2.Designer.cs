namespace Lab1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            A = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(591, 536);
            button1.Name = "button1";
            button1.Size = new Size(127, 48);
            button1.TabIndex = 0;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { A });
            dataGridView1.Location = new Point(17, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(333, 569);
            dataGridView1.TabIndex = 1;
            // 
            // A
            // 
            A.HeaderText = "A";
            A.MinimumWidth = 6;
            A.Name = "A";
            A.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 28);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 2;
            label1.Text = "N=";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "20";
            // 
            // button2
            // 
            button2.Location = new Point(591, 18);
            button2.Name = "button2";
            button2.Size = new Size(124, 40);
            button2.TabIndex = 4;
            button2.Text = "Обрахувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 91);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "Сума";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 141);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 6;
            label3.Text = "Сума додатніх";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 192);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 7;
            label4.Text = "Сума від'ємних";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 596);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn A;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}