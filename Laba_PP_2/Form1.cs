using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int step = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "182,5";
            textBox2.Text = "18,225";
            textBox3.Text = "-0,03298";
            textBox5.Text = "5";
            label1.Text = "Введите X:";
            label2.Text = "Введите Y:";
            label3.Text = "Введите Z:";
            label5.Text = "Введите Степень окр.:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            step = Convert.ToInt32(textBox5.Text);
            textBox4.Text = Convert.ToString(okr(Math.Abs(A(x, y)) - B(x, y, z)));
        }
        private double A(double x, double y)
        {
            return Math.Pow(x, YdX(x, y)) - Math.Pow(YdX(x, y), 0.3333333);
        }
        private double B(double x, double y, double z) 
        {
            return Y_X(x, y) * (Math.Cos(y) -  z/Y_X(x, y)) / (1 + Math.Pow(Y_X(x, y), 2));
        }
        private double YdX(double x, double y) { return y / x; }
        private double Y_X(double x, double y) { return y - x; }
        private double okr(double a){return ((double)((int)(a * Math.Pow(10, step)))) / Math.Pow(10, step);}
    }
}