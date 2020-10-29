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
    {   //ОТРИСОВЫВАТЬ ТОЛЬКО ОДИН РАЗ А НЕ ПЕРЕД КАРЖЫМ РИСОВАНИЕМ
        public abstract class Element
        {
            protected Graphics graphics;
            protected Page parent;
            public Element(Page parent, Color color, int x, int y) :this (parent, color) => SetFirstPoint(x, y);
            public Element(Page parent, Color color)
            {
                values = new List<int>() {0, 0, 0, 0 };
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
                parent.drawAll(-1);
            }
            public void SetFirstPoint(int x, int y)
            {
                values[0] = x;
                values[1] = y;
            }
            public virtual void Draw(int x1, int y1)
            {
                values[2] = x1;
                values[3] = y1;
                Draw();
            }
            public virtual void Draw()
            {
            }
            protected List<int> values;
            protected String type;
            protected Color color;
            public int GetX { get { return values[0]; } }
            public int GetY { get { return values[1]; } }
            public String GetTypeOfElement { get { return type; } }
            public Color GetColor { get { return color; } }
        }
        public class Circle : Element
        {
            public Circle(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Circle";
            public Circle(Page parent, Color color) : base(parent, color) => type = "Circle";
            public override void Draw(int x1, int y1)
            {
                dispose();
                base.Draw(x1, y1);
                Draw();
            }
            public override void Draw()
            {
                base.Draw();
                Pen pen = new Pen(color);
                graphics.DrawEllipse(pen, values[0], values[1], values[3], values[3]);
            }
        }
        public class DirectLine : Element
        {
            public DirectLine(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "DirectLine";
            public DirectLine(Page parent, Color color) : base(parent, color) => type = "DirectLine";
            public override void Draw(int x1, int y1)
            {
                dispose();
                base.Draw(x1, y1);
            }
            public override void Draw()
            {
                base.Draw();
                Pen pen = new Pen(color);
                graphics.DrawLine(pen, values[0], values[1], values[2], values[3]);
            }
        }
        public class Line : Element  //Будет создавать много элементов DirectLine
        {
            public Line(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Line";
            public Line(Page parent, Color color) : base(parent, color) => type = "Line";
            public override void Draw(int x1, int y1)
            {
                dispose();
                values.Add(x1);
                values.Add(y1);
                Draw();
            }
            public override void Draw()
            {
                base.Draw();
                Pen pen = new Pen(color);
                for (int step = 0; step < values.Count-2; step += 2)
                    graphics.DrawLine(pen, values[step], values[step + 1], values[step + 2], values[step + 3]);
            }

        }
        public class Rectangle : Element
        {
            public Rectangle(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Rectangle";
            public Rectangle(Page parent, Color color) : base(parent, color) => type = "Rectangle";
            public override void Draw(int x1, int y1)
            {
                dispose();
                base.Draw(x1, y1);
            }
            public override void Draw()
            {
                base.Draw();
                Pen pen = new Pen(color);
                graphics.DrawRectangle(pen, values[0], values[1], values[2], values[3]);
            }
        }
        public class Ellipse : Element
        {
            public Ellipse(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Ellipse";
            public Ellipse(Page parent, Color color) : base(parent, color) => type = "Ellipse";
            public override void Draw(int x1, int y1)
            {
                dispose();
                base.Draw(x1, y1);
            }
            public override void Draw()
            {
                base.Draw();
                Pen pen = new Pen(color);
                graphics.DrawEllipse(pen, values[0], values[1], values[2], values[3]);
            }
        }
    }
}
