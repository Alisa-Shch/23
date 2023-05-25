using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int n = 2;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            n = comboBox1.SelectedIndex + 2;
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            int[,] arr = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(10);
                    textBox1.Text += String.Format($"{arr[i, j],-5}");
                }
                textBox1.Text += String.Format("\r\n");
            }
            textBox1.Enabled = false;
            if (radioStroka.Checked && radioUp.Checked)
                SortRowUp(ref arr);
            else if (radioStroka.Checked && radioDown.Checked)
                SortRowDown(ref arr);
            else if (radioStolb.Checked && radioUp.Checked)
                SortColumnUp(ref arr);
            else if (radioStolb.Checked && radioDown.Checked)
                SortColumnDown(ref arr);
            textBox2.Text = null;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    textBox2.Text += String.Format($"{arr[i, j],-5}");
                }
                textBox2.Text += String.Format("\r\n");
            }
            textBox2.Enabled = false;
        }
        void SortRowUp(ref int[,] arr)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (arr[i, j] > arr[i, j + 1])
                        {
                            int a = arr[i, j];
                            arr[i, j] = arr[i, j + 1];
                            arr[i, j + 1] = a;
                            flag = true;
                        }
                    }
                }
            }
        }
        void SortRowDown(ref int[,] arr)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (arr[i, j] < arr[i, j + 1])
                        {
                            int a = arr[i, j];
                            arr[i, j] = arr[i, j + 1];
                            arr[i, j + 1] = a;
                            flag = true;
                        }
                    }
                }
            }
        }
        void SortColumnUp(ref int[,] arr)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (arr[j, i] > arr[j + 1, i])
                        {
                            int a = arr[j, i];
                            arr[j, i] = arr[j + 1, i];
                            arr[j + 1, i] = a;
                            flag = true;
                        }
                    }
                }
            }
        }
        void SortColumnDown(ref int[,] arr)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (arr[j, i] < arr[j + 1, i])
                        {
                            int a = arr[j, i];
                            arr[j, i] = arr[j + 1, i];
                            arr[j + 1, i] = a;
                            flag = true;
                        }
                    }
                }
            }
        }
    }
}