using NeuroTrainer.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            public Element(Page parent, Color color, int x, int y) :this (parent, color)
            {
                this.x = x;
                this.y = y;
            }
            public Element(Page parent, Color color)
            {
                if (parent == null) throw new PageIsNullException();
                this.parent = parent;
                parent.addElement(this);
                this.color = color;
                graphics = parent.form.CreateGraphics();
            }
            public void SetFirstPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual void Draw(int x1, int x2)
            {
                this.x1 = x1;
                this.x2 = x2;
            }
            protected int x;
            protected int y;
            protected int x1;
            protected int x2;
            protected String type;
            protected Color color;
            public int GetX { get { return x; } }
            public int GetY { get { return y; } }
            public String GetTypeOfElement { get { return type; } }
            public Color GetColor { get { return color; } }
        }
        public class Circle : Element
        {
            public Circle(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Circle";
            public Circle(Page parent, Color color) : base(parent, color) => type = "Circle";
        }
        public class DirectLine : Element
        {
            public DirectLine(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "DirectLine";
            public DirectLine(Page parent, Color color) : base(parent, color) => type = "DirectLine";
            public override void Draw(int x1, int x2)
            {
                graphics.Clear(parent.form.BackColor);
                base.Draw(x1, x2);
                Pen pen = new Pen(color);
                Point p1 = new Point(x, y);
                Point p2 = new Point(x1, x2);
                Page page = new Page(parent.form);
                Line line = new Line(page, pen, p1, p2);
                graphics.DrawLine(pen, p1, p2);
                //Как удалить нарисованнный объект
            }
        }
        public class Line : Element  //Будет создавать много элементов DirectLine
        {
            public Line(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Line";
            public Line(Page parent, Color color) : base(parent, color) => type = "Line";
        }
        public class Rectangle : Element
        {
            public Rectangle(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Rectangle";
            public Rectangle(Page parent, Color color) : base(parent, color) => type = "Rectangle";
        }
        public class Ellipse : Element
        {
            public Ellipse(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Ellipse";
            public Ellipse(Page parent, Color color) : base(parent, color) => type = "Ellipse";
        }
    }
}
