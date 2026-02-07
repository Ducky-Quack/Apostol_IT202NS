using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apostol_IT202_NS_LABACT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResult.Text = "";
            groupBox1.AutoSize = true;
            //groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double numb1, numb2, numb3, numb4, numb5;

            double.TryParse(textBox1.Text, out numb1);
            double.TryParse(textBox2.Text, out numb2);
            double.TryParse(textBox3.Text, out numb3);
            double.TryParse(textBox4.Text, out numb4);
            double.TryParse(textBox5.Text, out numb5);

            // Absolute
            double absnum1 = Math.Abs(numb1);
            double absnum2 = Math.Abs(numb2);
            double absnum3 = Math.Abs(numb3);
            double absnum4 = Math.Abs(numb4);
            double absnum5 = Math.Abs(numb5);

            //Sqaure Root
            double sqrtnum1 = Math.Round(Math.Sqrt(numb1), 2);
            double sqrtnum2 = Math.Round(Math.Sqrt(numb2), 2);
            double sqrtnum3 = Math.Round(Math.Sqrt(numb3), 2);
            double sqrtnum4 = Math.Round(Math.Sqrt(numb4), 2);
            double sqrtnum5 = Math.Round(Math.Sqrt(numb5), 2);

            //Floor
            double floornum1 = Math.Floor(numb1);
            double floornum2 = Math.Floor(numb2);
            double floornum3 = Math.Floor(numb3);
            double floornum4 = Math.Floor(numb4);
            double floornum5 = Math.Floor(numb5);
            
            //Maximum and Minimum
            double max = Math.Max(Math.Max(Math.Max(Math.Max(numb1, numb2), numb3), numb4), numb5);
            double min = Math.Min(Math.Min(Math.Min(Math.Min(numb1, numb2), numb3), numb4), numb5);

            labelResult.Text =
                $"Absolute Values: {absnum1}, {absnum2}, {absnum3}, {absnum4}, {absnum5}" +
                $"\nSquare Roots: {sqrtnum1}, {sqrtnum2}, {sqrtnum3}, {sqrtnum4}, {sqrtnum5}" +
                $"\nFloor Values: {floornum1}, {floornum2}, {floornum3}, {floornum4}, {floornum5}" +
                $"\nMaximum Value: {max} \nMinimum Value: {min}";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
