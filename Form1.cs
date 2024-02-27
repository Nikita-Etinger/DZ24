using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintcw
{
    public partial class Form1 : Form
    { 
        List<Point> points = new List<Point>();   
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //int size=50;
            //foreach(Point p in points)
            //{
            //    g.FillEllipse(Brushes.Red, p.X-size/2, p.Y - size / 2, size, size);
            //}

            //Graphics g = e.Graphics;
            //int x = 25; int y=25;
            //int h=60; int w=60;
            //Pen pn=new Pen(Brushes.Red,5);
            //Point pt=new Point(10,10);
            //Size s = new Size(200,150);
            //Rectangle r1=new Rectangle(pt,s);
            //Rectangle r2 = new Rectangle(x, y,w,h);
            //g.FillRectangle(Brushes.Black, r1);
            //g.DrawRectangle(pn, r2);



            Graphics g = e.Graphics;
            //Point a = new Point(50, 50);
            //Point b = new Point(240, 140);
            //g.SmoothingMode = SmoothingMode.HighQuality;
            //Pen p = new Pen(Brushes.Red, 10);
            //p.StartCap = LineCap.SquareAnchor;
            //p.EndCap = LineCap.ArrowAnchor;
            //p.DashStyle = DashStyle.DashDotDot;

            ////прямоугольник, в который вписана дуга
            //Rectangle rect = new Rectangle(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y), Math.Abs(b.X - a.X), Math.Abs(b.Y - a.Y));

            //// начальный угол и конечный угол для дуги
            //float startAngle = (float)(Math.Atan2(b.Y - a.Y, b.X - a.X) * 180 / Math.PI);
            //float sweepAngle = 210; 


            //g.DrawArc(p, rect, startAngle, sweepAngle);

            Point[] points = {
             new Point(5, 10),
             new Point(23, 130),
             new Point(130, 57)};

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddEllipse(170, 170, 100, 50);
            g.FillPath(Brushes.Aqua, path);
            path.StartFigure();
            path.AddCurve(points, 0.5F);
            path.AddArc(100, 50, 100, 100, 0, 120);
            path.AddLine(50, 150, 50, 220);
            path.CloseFigure();
            path.StartFigure();
            path.AddArc(180, 30, 60, 60, 0, -170);

            g.DrawPath(new Pen(Color.Blue, 3), path);
            g.Dispose();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            Invalidate();
        }
    }
}
