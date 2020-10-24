using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NeuroTrainer.Classes
{
    public static class Figures
    {
        public abstract class Element
        {
            Page parent;
            public Element(Page parent, Color color, int x, int y)
            {
                this.parent = parent;
                parent.addElement(this);
            }
            protected int x;
            protected int y;
            protected String type;

            public int GetX { get { return x; } }
            public int GetY { get { return y; } }
            public String GetTypeOfElement { get { return type; } }
            public static Color color;
        }
        public class Circle : Element
        {
            public Circle(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Circle";
        }
        public class DirectLine : Element
        {
            public DirectLine(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "DirectLine";
        }
        public class Line : Element
        {
            public Line(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Line";
        }
        public class Rectangle : Element
        {
            public Rectangle(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Rectangle";
        }
        public class Ellipse : Element
        {
            public Ellipse(Page parent, Color color, int x, int y) : base(parent, color, x, y) => type = "Ellipse";
        }
    }
}
