using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KablosuzProje
{
    public partial class Form1 : Form
    {
        public Point mp = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Point r1 = new Point(Convert.ToInt16(txt_r1x.Text) * 25, Convert.ToInt16(txt_r1y.Text) * 25);
                Point r2 = new Point(Convert.ToInt16(txt_r2x.Text) * 25, Convert.ToInt16(txt_r2y.Text) * 25);
                Point r3 = new Point(Convert.ToInt16(txt_r3x.Text) * 25, Convert.ToInt16(txt_r3y.Text) * 25);
                Point p1 = new Point(0, 0);
                Point p2 = new Point(500, 0);
                Point p3 = new Point(0, 0);
                Point p4 = new Point(0, 500);
                for (int i = 0; i < 20; i++)
                {
                    e.Graphics.DrawString(i.ToString(), new Font("Arial", 7), new SolidBrush(Color.Black), 0, p1.Y);
                    if (i > 0)
                        e.Graphics.DrawString(i.ToString(), new Font("Arial", 7), new SolidBrush(Color.Black), p3.X, 0);
                    e.Graphics.DrawLine(Pens.Gray, p1, p2);
                    p1.Y += 25;
                    p2.Y += 25;
                    e.Graphics.DrawLine(Pens.Gray, p3, p4);
                    p3.X += 25;
                    p4.X += 25;
                }
                double d1 = Math.Pow(((Math.Pow((mp.X - r1.X), 2)) + (Math.Pow((mp.Y - r1.Y), 2))), 0.5);
                double d2 = Math.Pow(((Math.Pow((mp.X - r2.X), 2)) + (Math.Pow((mp.Y - r2.Y), 2))), 0.5);
                double d3 = Math.Pow(((Math.Pow((mp.X - r3.X), 2)) + (Math.Pow((mp.Y - r3.Y), 2))), 0.5);
                Rectangle rect1 = new Rectangle(r1.X - 3, r1.Y - 3, 9, 9);
                Rectangle rect2 = new Rectangle(r2.X - 3, r2.Y - 3, 9, 9);
                Rectangle rect3 = new Rectangle(r3.X - 3, r3.Y - 3, 9, 9);
                Rectangle rect1_ = new Rectangle(r1.X - (int)d1, r1.Y - (int)d1, (int)d1 * 2, (int)d1 * 2);
                Rectangle rect2_ = new Rectangle(r2.X - (int)d2, r2.Y - (int)d2, (int)d2 * 2, (int)d2 * 2);
                Rectangle rect3_ = new Rectangle(r3.X - (int)d3, r3.Y - (int)d3, (int)d3 * 2, (int)d3 * 2);
                Rectangle mobileRect = new Rectangle(mp.X - 3, mp.Y - 3, 9, 9);
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), rect1);
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), rect2);
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), rect3);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), mobileRect);
                e.Graphics.DrawString("B1", new Font("Arial", 8), new SolidBrush(Color.Black), r1.X + 6, r1.Y + 6);
                e.Graphics.DrawString("B2", new Font("Arial", 8), new SolidBrush(Color.Black), r2.X + 6, r2.Y + 6);
                e.Graphics.DrawString("B3", new Font("Arial", 8), new SolidBrush(Color.Black), r3.X + 6, r3.Y + 6);
                e.Graphics.DrawString("M1", new Font("Arial", 8), new SolidBrush(Color.Black), mp.X + 6, mp.Y + 6);
                e.Graphics.DrawEllipse(Pens.Black, rect1_);
                e.Graphics.DrawEllipse(Pens.Black, rect2_);
                e.Graphics.DrawEllipse(Pens.Black, rect3_);
                e.Graphics.DrawLine(Pens.Black, r1, mp);
                e.Graphics.DrawLine(Pens.Black, r2, mp);
                e.Graphics.DrawLine(Pens.Black, r3, mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void txt_r1x_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kablosuz Ağların Modellenmesi ve Analizi Dersi Proje Ödevi\nHazırlayan:\nFurkan Bozkurt\nNo:Y195012058");
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            mp.X = Form1.MousePosition.X - Form1.ActiveForm.DesktopLocation.X - 23;
            mp.Y = Form1.MousePosition.Y - Form1.ActiveForm.DesktopLocation.Y - 46;
            lbl_location.Text = $"({mp.X},{mp.Y})";
            pictureBox.Refresh();
        }

        public Point Calculate(Point p1, Point p2, Point p3, double r1, double r2, double r3)
        {
            return new Point(0,0);
        }
    }
}
