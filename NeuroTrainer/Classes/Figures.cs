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
            protected void dispose()
            {
                graphics.Clear(parent.form.BackColor);
                graphics = parent.form.CreateGraphics();
                parent.drawAll();
            }
            public void SetFirstPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual void Draw(int x1, int y1)
            {
                this.x1 = x1;
                this.y1 = y1;
            }
            public virtual void Draw()
            {
            }
            protected int x;
            protected int y;
            protected int x1;
            protected int y1;
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
            public override void Draw(int x1, int y1)
            {
                base.Draw(x1, y1);
                dispose();
                Pen pen = new Pen(color);
                graphics.DrawLine(pen, x, y, x1, y1);
            }
            public override void Draw()
            {
                base.Draw();
                Pen pen = new Pen(color);
                graphics.DrawLine(pen, x, y, x1, y1);
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
