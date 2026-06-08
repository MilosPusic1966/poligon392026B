using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poligon392026B
{
    public partial class Form1 : Form
    {
        Tacka[] temena;
        int br_temena;
        Poligon radni;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temena = new Tacka[20];
            br_temena = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            Tacka nova = new Tacka(x, y);
            temena[br_temena] = nova;
            listBox1.Items.Add(x.ToString()+" "+y.ToString());
            br_temena++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radni = new Poligon(br_temena, temena);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radni.snimi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (radni.konveksan()) label3.Text = "Konveksan";
                else label3.Text = "Nije Konveksan";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radni.prost()) label3.Text = "Prost";
            else label3.Text = "Nije prost";
        }
    }
}
