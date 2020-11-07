using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroTrainer.Classes
{
    public class Page
    {
        private List<Figures.Element> elements;
        private File.Settings settings;
        public List<Figures.Element> getFigures { get { return elements; } }
        public Drawing_Form form { get; set; }
        public void addElement(Figures.Element element)
        {
            elements.Add(element);
        }
        public void drawAll()
        {
            foreach(Figures.Element element in elements) element.draw();
        }
        public void reDrawAll()
        {
            for(int step = elements.Count-1; step >= 0; step--) elements[step].draw();
        }
        public Page(Drawing_Form form)
        {
            this.form = form;
            Graphics graphics = form.CreateGraphics();
            graphics.Clear(form.BackColor);
            graphics.Dispose();
            settings = new File.Settings(form);
            elements = new List<Figures.Element>();
        }
        public Page(Drawing_Form form, File.Integrate integrated) : this(form)
        {
            settings.Heigh_Page = integrated.heigh_Drawing_Form;
            settings.Width_Page = integrated.width_Drawing_Form;
            Figures.Element element;
            for (int step = 0; step < integrated.colors.Count; step++)
            {
                switch (integrated.types[step])
                {
                    case "Circle":
                        element = new Figures.Circle(this, Color.FromArgb(integrated.colors[step]), integrated.values[step][0], integrated.values[step][1]);
                        element.draw(integrated.values[step][2], integrated.values[step][3]);
                        break;
                    case "DirectLine":
                        element = new Figures.DirectLine(this, Color.FromArgb(integrated.colors[step]), integrated.values[step][0], integrated.values[step][1]);
                        element.draw(integrated.values[step][2], integrated.values[step][3]);
                        break;
                    case "Line":
                        element = new Figures.Line(this, Color.FromArgb(integrated.colors[step]), integrated.values[step][0], integrated.values[step][1]);
                        for(int inStep = 2; inStep < integrated.values[step].Count-2; inStep+=2) element.draw(integrated.values[step][inStep], integrated.values[step][inStep+1]);
                        break;
                    case "Rectangle":
                        element = new Figures.Rectangle(this, Color.FromArgb(integrated.colors[step]), integrated.values[step][0], integrated.values[step][1]);
                        element.draw(integrated.values[step][2], integrated.values[step][3]);
                        break;
                    case "Ellipse":
                        element = new Figures.Ellipse(this, Color.FromArgb(integrated.colors[step]), integrated.values[step][0], integrated.values[step][1]);
                        element.draw(integrated.values[step][2], integrated.values[step][3]);
                        break;
                }
            }
            File.Settings.color = Color.Black;
        }
        public File.Integrate OutIntegrate()
        {
            File.Integrate integrated = new File.Integrate();
            integrated.heigh_Drawing_Form = settings.Heigh_Page;
            integrated.width_Drawing_Form = settings.Width_Page;
            foreach(Figures.Element element in elements)
            {
                integrated.colors.Add(element.Color.ToArgb());
                integrated.types.Add(element.GetType().Name);
                List<int> values = new List<int>();
                foreach(Point point in element.List)
                {
                    values.Add(point.X);
                    values.Add(point.Y);
                }
                integrated.values.Add(values);
            }
            return integrated;
        }
    }
}
