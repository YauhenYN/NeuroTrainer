using System;
using System.Collections.Generic;
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
        public List<Figures.Element> GetElements { get { return elements; } }
        public Drawing_Form form { get; set; }
        public void addElement(Figures.Element element)
        {
            elements.Add(element);
        }
        public void drawAll()
        {
            foreach(Figures.Element element in elements) element.Draw();
        }
        public void drawAll(bool isLast)
        {
            for(int step = 0; step < elements.Count-1; step++) elements[step].Draw();
        }
        public Page(Drawing_Form form)
        {
            this.form = form;
            settings = new File.Settings(form);
            elements = new List<Figures.Element>();
        }
    }
}
