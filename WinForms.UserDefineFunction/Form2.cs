using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.UserDefineFunction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = 0.0;
            double weight = 0.0;
            double trianglearea = 0.0;
            if (double.TryParse(textBox1.Text, out height)
                && double.TryParse(textBox2.Text, out weight))
            {
                trianglearea = CalTriansleArea(height, weight);
                label5.Text = trianglearea.ToString("F2");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
        private double CalTriansleArea(double height, double weight)
        {
            double area = 0.5 * height * weight;
            return area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double ciclearea = 0.0;
            double area = 0.0;
            if (double.TryParse(textBox4.Text, out r))
            {
                ciclearea = CalCicle(r);
                area = CalArea(r);
                label10.Text = ciclearea.ToString("F2");
                label15.Text = area.ToString("F2");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
        private double CalArea(double r)
        {
            double area = 2 * Math.PI * r;
            return area;
        }
        private double CalCicle(double r)
        {
            double Carea = Math.PI * r * r;
            return Carea;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox3.Text, out i))
            {
                label18.Text = i.ToString();
                label20.Text = RandomNextNumber(ref i).ToString();
                textBox3.Text = i.ToString();
            }
        }

        private int RandomNextNumber(ref int x)
        {
            Random rnd = new Random();
            x += rnd.Next(1, 100);
            return x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sumary = 0.0;
            string[] input = textBox5.Lines;
            double[] number = new double[input.Length];
            for(int i  = 0; i < input.Length; i++)
            {
                if(!double.TryParse(input[i], out number[i]))
                {
                    number[i] = 0.0;
                }
            }
            sumary = CalSum(number);
            MessageBox.Show("ผลรวม = " + sumary.ToString("F2"));
        }
        private double CalSum(double[] number)
        {
            return number.Sum();
        }
    }
}