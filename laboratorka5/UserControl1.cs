using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorka5
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* var tabul = new Tabulistan();
            tabul.GetList(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

            listBox1.Items.Clear();
            
            for(int i = 0; i < tabul.points.Count; i++)
            {
                listBox1.Items.Add("x = " + Math.Round(tabul.points[i].X, 2).ToString()
                    + "y = " + Math.Round(tabul.points[i].Y, 3).ToString()
                    + "Цикл = " + Math.Round(tabul.points[i].Cycle, 3).ToString()
                    + "Рекурсія = " + Math.Round(tabul.points[i].Rec, 3).ToString());
            } */
        }
    }
}
