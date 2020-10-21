using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroTrainer.Classes
{
    public static class Figures
    {
        private static List<Element> elements = new List<Element>();
        public static List<Element> GetElements { get { return elements; } }
        public abstract class Element
        {
            public Element()
            {
                elements.Add(this);
            }
            protected int x;
            protected int y;
            protected String type;
            protected Element element;

            public int GetX { get { return x; } }
            public int GetY { get { return y; } }
            public String GetTypeOfElement { get { return type; } }
            public Element GetElement { get { return element; } }
        }
        public class Circle : Element
        {
            public Circle(int x, int y)
            {
                this.x = x;
                this.y = y;
                type = "Circle";
                element = this;
            }
        }
        public class DirectLine : Element
        {
            public DirectLine(int x, int y)
            {
                this.x = x;
                this.y = y;
                type = "DirectLine";
                element = this;
            }
        }
        public class Line : Element
        {
            public Line(int x, int y)
            {
                this.x = x;
                this.y = y;
                type = "Line";
                element = this;
            }
        }
        public class Rectangle : Element
        {
            public Rectangle(int x, int y)
            {
                this.x = x;
                this.y = y;
                type = "Rectangle";
                element = this;
            }
        }
        public class Ellipse : Element
        {
            public Ellipse(int x, int y)
            {
                this.x = x;
                this.y = y;
                type = "Ellipse";
                element = this;
            }
        }
    }
}
