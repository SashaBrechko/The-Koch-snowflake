using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.White, 2);
            Pen p2 = new Pen(Color.LightSlateGray, 2);

            gr.DrawLine(p, 300, 400, 450, 200);
            gr.DrawLine(p, 450, 200, 600, 400);
            gr.DrawLine(p, 600, 400, 300, 400);

            int i = comboBox1.SelectedIndex + 1;


        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            float x1 = 300;
            float x2 = 450;
            float x3 = 600;

            float y1 = 400;
            float y2 = 200;
            float y3 = 400;


        }

        public void KochSnoflake(float x1, float x2, float x3, float y1, float y2, float y3, int i)
        {
            float P = 3/10;

            while (i > 0)
            {
                float nx1 = x1 + (x2 - x1) * P;
                float nx2 = x2 + (x3 - x2) * P;
                float nx3 = x3 + (x1 - x3) * P;

                float ny1 = y1 + (y2 - y1) * P;
                float ny2 = y2 + (y3 - y2) * P;
                float ny3 = y3 + (y1 - y3) * P;

                

                x1 = nx1;
                x2 = nx2;
                x3 = nx3;

                y1 = ny1;
                y2 = ny2;
                y3 = ny3;

                i--;
            }

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex + 1;
        }
    }
}
