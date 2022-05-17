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
    public partial class EllipseForm : Form
    {
        public EllipseForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Refresh();


            int xc = Convert.ToInt32(textBox12.Text);
            int yc = Convert.ToInt32(textBox13.Text);
            int rx = Convert.ToInt32(textBox14.Text);
            int ry = Convert.ToInt32(textBox15.Text);

            ellipseMidpoint(xc, yc, rx, ry);
        }

        void ellipsePlotPoints(int xc, int yc, int x, int y)
        {

            var BrushTool = Brushes.Red;
            var B = panel1.CreateGraphics();

            B.FillRectangle(BrushTool, xc + x, yc + y, 2, 2);
            B.FillRectangle(BrushTool, xc - x, yc + y, 2, 2);
            B.FillRectangle(BrushTool, xc + x, yc - y, 2, 2);
            B.FillRectangle(BrushTool, xc - x, yc - y, 2, 2);
        }

        void ellipseMidpoint(int xc, int yc, int rx, int ry)
        {
            int rx2 = rx * rx;
            int ry2 = ry * ry;
            int tworx2 = 2 * rx2;
            int twory2 = 2 * ry2;
            int p;
            int x = 0;
            int y = ry;
            int px = 0;
            int py = tworx2 * y;

            ellipsePlotPoints(xc, yc, x, y);

            /* Region 1 */
            p = (int)(ry2 - (rx2 * ry) + (0.25 * rx2));
            while (px < py)
            {
                x++;
                px += twory2;
                if (p < 0)
                    p += ry2 + px;
                else
                {
                    y--;
                    py -= tworx2;
                    p += ry2 + px - py;
                }
                ellipsePlotPoints(xc, yc, x, y);
            }

            /* Region 2 */
            p = ((int)(ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2));
            while (y > 0)
            {
                y--;
                py -= tworx2;
                if (p > 0)
                    p += rx2 - py;
                else
                {
                    x++;
                    px += twory2;
                    p += rx2 - py + px;
                }
                ellipsePlotPoints(xc, yc, x, y);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
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
