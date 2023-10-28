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
    public partial class Abstr : Form
    {
        public Abstr()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Abstr_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            var a = new Polynominal[n * 2];

            for(int i = 0; i < a.Length; i = i + 2)
            {
                a[i] = new Square(i + 1, (i + 1) * 2);
                a[i + 1] = new Qube(i + 2, (i + 2) * 2);
            }
            var maxS = 0.0;
            listBox1.Items.Clear();

            for(int i = 0; i < a.Length; i++)
            {
                listBox1.Items.Add(a[i].Show() + "; Значення: " + a[i].Value().ToString());
                if (a[i].Value() > maxS)
                {
                    maxS = a[i].Value();
                }
            }
            label7.Text = maxS.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
