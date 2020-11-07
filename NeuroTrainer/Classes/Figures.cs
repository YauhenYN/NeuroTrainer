using NeuroTrainer.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NeuroTrainer.Classes
{
    public static class Figures
    {   
        public abstract class Element
        {
            protected Graphics graphics;
            protected Page parent;
            public Element(Page parent, Color color, int x, int y) :this (parent, color) => setFirstPoint(x, y);
            public Element(Page parent, Color color)
            {
                if (parent == null) throw new PageIsNullException();
                this.parent = parent;
                this.color = color;
            }
            protected virtual void newList(int x, int y) => points = new List<Point>() { new Point(x, y), new Point()};
            protected void dispose()
            {
                graphics.Clear(parent.form.BackColor);
                graphics = parent.form.CreateGraphics();
                parent.reDrawAll();
            }
            public virtual void setFirstPoint(int x, int y)
            {
                graphics = parent.form.CreateGraphics();
                parent.addElement(this);
                newList(x, y);
            }
            public virtual void draw(int x1, int y1)
            {
                points[1] = new Point(x1, y1);
                draw();
            }
            public virtual void draw()
            {
            }
            public virtual void ifMouseDown()
            {
            }
            protected List<Point> points;
            protected Color color;
            public List<Point> List { get { return points; } }
            public Color Color { get { return color; } }
        }
        public class Circle : Element
        {
            public Circle(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Circle(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                base.draw(x1, y1);
                dispose();
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawEllipse(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
            }
        }
        public class DirectLine : Element
        {
            public DirectLine(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public DirectLine(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                base.draw(x1, y1);
                dispose();
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawLine(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
            }
        }
        public class Line : Element
        {
            public Line(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Line(Page parent, Color color) : base(parent, color) { }
            protected override void newList(int x, int y) => points = new List<Point>() { new Point(x, y) };
            public override void draw(int x, int y)
            {
                points.Add(new Point(x, y));
                draw();
            }
            public override void setFirstPoint(int x, int y)
            {
                base.setFirstPoint(x, y);
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                for (int step = 0; step < points.Count-1; step++) graphics.DrawLine(pen, points[step].X, points[step].Y, points[step+1].X, points[step+1].Y);
            }

        }
        public class Rectangle : Element
        {
            public Rectangle(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Rectangle(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                base.draw(x1, y1);
                dispose();
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawRectangle(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
            }
        }
        public class Ellipse : Element
        {
            public Ellipse(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Ellipse(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                base.draw(x1, y1);
                dispose();
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawEllipse(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
            }
        }
    }
}
