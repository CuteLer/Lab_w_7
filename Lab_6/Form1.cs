using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        double [] mas = new double [25];
        int count_1, count_2;
        List<double> val = new List<double>(); 

        public void input(double [] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.NextDouble() * random.Next(-50,50);
            }
        }
        public void print(TextBox text, double [] mas)
        {
            for(int i = 0; i < mas.Length;i++)
            {
                text.Text += "Ar[" + i + "]" + " = " + Math.Round(mas[i],2) + Environment.NewLine; 
            }
        }

        public void count (double [] mas, out int count_1, out int count_2, List<double> val)
        {
            count_1 = 0;
            count_2 = 0;
            
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                    count_1++;
                else
                    if(mas[i] >= 1 && mas[i] <= 2)
                    {
                        val.Add(mas[i]);
                        count_2++;
                    }
                        
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input(mas);
            print(textBox1, mas);
            textBox1.Text += Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count(mas, out count_1, out count_2, val);
            textBox2.Text += "Число отрицательных элементов: " + count_1 + Environment.NewLine
                + "Промежутку [1;2] принадлежит " + count_2 + "ч.";
            if(count_2 != 0)
                textBox2.Text +=  ":"  + Environment.NewLine;
            else
                textBox2.Text += Environment.NewLine;
            for(int i = 0; i < val.Count; i++)
                textBox2.Text += val[i] + Environment.NewLine;
            val.Clear();
            textBox2.Text += Environment.NewLine;
        }
    }
}
