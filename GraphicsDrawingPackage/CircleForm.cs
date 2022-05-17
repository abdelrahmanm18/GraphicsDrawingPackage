using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDrawingPackage
{
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }

        private void CircleForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Refresh();


            int xc = Convert.ToInt32(textBox9.Text);
            int yc = Convert.ToInt32(textBox10.Text);
            int r = Convert.ToInt32(textBox11.Text);

            circleMidPoint(xc, yc, r);
        }

        void circlePlotPoints(int xc, int yc, int x, int y)
        {

            var BrushTool = Brushes.Red;
            var B = panel1.CreateGraphics();

            B.FillRectangle(BrushTool, xc + x, yc + y, 2, 2);
            B.FillRectangle(BrushTool, xc - x, yc + y, 2, 2);
            B.FillRectangle(BrushTool, xc + x, yc - y, 2, 2);
            B.FillRectangle(BrushTool, xc - x, yc - y, 2, 2);
            B.FillRectangle(BrushTool, xc + y, yc + x, 2, 2);
            B.FillRectangle(BrushTool, xc - y, yc + x, 2, 2);
            B.FillRectangle(BrushTool, xc + y, yc - x, 2, 2);
            B.FillRectangle(BrushTool, xc - y, yc - x, 2, 2);
        }

        void circleMidPoint(int xc, int yc, int r)
        {
            int x = 0;
            int y = r;
            int p = 1 - r;

            circlePlotPoints(xc, yc, x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }

                circlePlotPoints(xc, yc, x, y);
            }
        }

        

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePageForm f1 = new HomePageForm();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
