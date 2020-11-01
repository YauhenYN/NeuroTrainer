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
                parent.addElement(this);
                this.color = color;
                graphics = parent.form.CreateGraphics();
            }
            protected void newList() => values = new List<int>() { 0, 0, 0, 0 };
            protected void dispose()
            {
                graphics.Clear(parent.form.BackColor);
                graphics = parent.form.CreateGraphics();
                parent.drawAll(true);
            }
            public virtual void setFirstPoint(int x, int y)
            {
                newList();
                values[0] = x;
                values[1] = y;
            }
            public virtual void draw(int x1, int y1)
            {
                values[2] = x1;
                values[3] = y1;
                draw();
            }
            public virtual void draw()
            {
            }
            public virtual void ifMouseDown()
            {
            }
            protected List<int> values;
            protected Color color;
            public List<int> List { get { return values; } }
            public Color Color { get { return color; } }
        }
        public class Circle : Element
        {
            public Circle(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Circle(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                dispose();
                base.draw(x1, y1);
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawEllipse(pen, values[0], values[1], values[3], values[3]);
            }
        }
        public class DirectLine : Element
        {
            public DirectLine(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public DirectLine(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                dispose();
                base.draw(x1, y1);
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawLine(pen, values[0], values[1], values[2], values[3]);
            }
        }
        public class Line : Element  //Будет создавать много элементов DirectLine
        {
            public Line(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Line(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x, int y)
            {
                values.Add(x);
                values.Add(y);
                draw();
            }
            public override void setFirstPoint(int x, int y)
            {
                values = new List<int>() { x, y };
                dispose();
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                for (int step = 0; step < values.Count - 2; step += 2) graphics.DrawLine(pen, values[step], values[step + 1], values[step + 2], values[step + 3]);
            }

        }
        public class Rectangle : Element
        {
            public Rectangle(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Rectangle(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                dispose();
                base.draw(x1, y1);
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawRectangle(pen, values[0], values[1], values[2], values[3]);
            }
        }
        public class Ellipse : Element
        {
            public Ellipse(Page parent, Color color, int x, int y) : base(parent, color, x, y) { }
            public Ellipse(Page parent, Color color) : base(parent, color) { }
            public override void draw(int x1, int y1)
            {
                dispose();
                base.draw(x1, y1);
            }
            public override void draw()
            {
                base.draw();
                Pen pen = new Pen(color);
                graphics.DrawEllipse(pen, values[0], values[1], values[2], values[3]);
            }
        }
    }
}
