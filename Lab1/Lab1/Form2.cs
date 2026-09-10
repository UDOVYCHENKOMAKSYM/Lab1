using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lab1.Class_lab1;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                int n= Convert.ToInt32(textBox1.Text);
                Arrays a = new Arrays(n);
                for (int i = 0; i < a.Lenght; i++)
                {
                    dataGridView1.Rows.Add(a[i].ToString());
                }
                var sum = a.Sum;
                label2.Text = sum.Item1.ToString();
                label3.Text = sum.Item2.ToString();
                label4.Text = sum.Item3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
