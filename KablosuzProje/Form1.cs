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
        public PointF mp = new Point(-1, -1);
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
                RectangleF mobileRect = new RectangleF(mp.X - 3, mp.Y - 3, 9, 9);
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), rect1);
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), rect2);
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), rect3);
                e.Graphics.DrawString("B1", new Font("Arial", 8), new SolidBrush(Color.Black), r1.X + 6, r1.Y + 6);
                e.Graphics.DrawString("B2", new Font("Arial", 8), new SolidBrush(Color.Black), r2.X + 6, r2.Y + 6);
                e.Graphics.DrawString("B3", new Font("Arial", 8), new SolidBrush(Color.Black), r3.X + 6, r3.Y + 6);
                if (mp.X >= 0 && mp.Y >= 0)
                {
                    e.Graphics.FillEllipse(new SolidBrush(Color.Red), mobileRect);
                    e.Graphics.DrawString("M1", new Font("Arial", 8), new SolidBrush(Color.Black), mp.X + 6, mp.Y + 6);
                    e.Graphics.DrawEllipse(Pens.Black, rect1_);
                    e.Graphics.DrawEllipse(Pens.Black, rect2_);
                    e.Graphics.DrawEllipse(Pens.Black, rect3_);
                    e.Graphics.DrawLine(Pens.Black, r1, mp);
                    e.Graphics.DrawLine(Pens.Black, r2, mp);
                    e.Graphics.DrawLine(Pens.Black, r3, mp);
                }
                mp.X = -1;
                mp.Y = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            var p = Calculate(new Point(Convert.ToInt16(txt_r1x.Text), Convert.ToInt16(txt_r1y.Text)),
                new Point(Convert.ToInt16(txt_r2x.Text), Convert.ToInt16(txt_r2y.Text)),
                new Point(Convert.ToInt16(txt_r3x.Text), Convert.ToInt16(txt_r3y.Text)),
                Convert.ToDouble(txt_r1.Text), Convert.ToDouble(txt_r2.Text), Convert.ToDouble(txt_r3.Text));
            mp.X = p.X * 25;
            mp.Y = p.Y * 25;
            lbl_location.Text = $"({p.X} . {p.Y})";
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

        public PointF Calculate(Point p1, Point p2, Point p3, double r1, double r2, double r3)
        {
            var x1 = p1.X;
            var x2 = p2.X;
            var x3 = p3.X;
            var y1 = p1.Y;
            var y2 = p2.Y;
            var y3 = p3.Y;
            var a = y3 - y2;
            var b = y1 - y3;
            var c = x2 - x3;
            var d = x3 - x1;
            var x_ = (Math.Pow(r1, 2) - Math.Pow(r3, 2)) - (Math.Pow(x1, 2) - Math.Pow(x3, 2)) - (Math.Pow(y1, 2) - Math.Pow(y3, 2));
            var y_ = (Math.Pow(r2, 2) - Math.Pow(r3, 2)) - (Math.Pow(x2, 2) - Math.Pow(x3, 2)) - (Math.Pow(y2, 2) - Math.Pow(y3, 2));
            var det = (x3 - x1) * (y3 - y2) - (y3 - y1) * (x3 - x2);
            var x = (a * x_ + b * y_) / (2 * det);
            var y = (c * x_ + d * y_) / (2 * det);
            return new PointF((float)x, (float)y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            //var x = (Form1.MousePosition.X - Form1.ActiveForm.DesktopLocation.X - 23) / 25.0;
            //var y = (Form1.MousePosition.Y - Form1.ActiveForm.DesktopLocation.Y - 46) / 25.0;
            try
            {

                var x = (Form1.MousePosition.X - Form1.ActiveForm.DesktopLocation.X - 22) / 25.0;
                var y = (Form1.MousePosition.Y - Form1.ActiveForm.DesktopLocation.Y - 45) / 25.0;
                lbl_coordinates.Text = $"({x}. {y})";
            }
            catch
            {

            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            mp.X = (Form1.MousePosition.X - Form1.ActiveForm.DesktopLocation.X - 22);
            mp.Y = (Form1.MousePosition.Y - Form1.ActiveForm.DesktopLocation.Y - 45);

            lbl_location.Text = $"({mp.X / 25.0} . {mp.Y / 25.0})";
            pictureBox.Refresh();
        }
    }
}
