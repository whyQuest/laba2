using labka5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба2
{
    public partial class lab5 : Form
    {


        public lab5()
        {
            InitializeComponent();
        }

        private Class1 class1 = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {
            double start = Convert.ToDouble(textBox1.Text);
            double end = Convert.ToDouble(textBox2.Text);
            double step = Convert.ToDouble(textBox3.Text);

            listBox1.Items.Clear();
            for (double x = start; x <= end; x += step)
            {
                listBox1.Items.Add($"Цикл: х = {x}, значення ряду: {class1.CalcCycle(x, end)}");
                listBox1.Items.Add($"Рекурсия: х = {x}, значення ряду: {class1.CalcWithRec(x, end)}");
                    listBox1.Items.Add($"Сінус: х = {x}, значення: {Math.Sin(-x)}");
            }
        }
    }
}
