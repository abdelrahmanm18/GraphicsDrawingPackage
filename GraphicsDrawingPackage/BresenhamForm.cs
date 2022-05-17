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
    public partial class BresenhamForm : Form
    {
        public BresenhamForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Point1
            int x1 = Convert.ToInt32(textBox5.Text);
            int y1 = Convert.ToInt32(textBox6.Text);

            // Point2
            int x2 = Convert.ToInt32(textBox7.Text);
            int y2 = Convert.ToInt32(textBox8.Text);

            BresenhamLine(x1, y1, x2, y2);
        }

        void BresenhamLine(int x0, int y0, int xEnd, int yEnd)
        {
            var BrushTool = Brushes.Red;
            var B = panel1.CreateGraphics();

            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);

            /* Determine endpoint to use as start position.  */
            if (x0 > xEnd)
            {
                x = xEnd;
                y = yEnd;
                xEnd = x0;
            }
            else
            {
                x = x0;
                y = y0;
            }

            B.FillRectangle(BrushTool, x, y, 2, 2);

            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                B.FillRectangle(BrushTool, x, y, 2, 2);
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
