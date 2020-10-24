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
        public void addElement(Figures.Element element)
        {
            elements.Add(element);
        }
        public Page(Drawing_Form form)
        {
            settings = new File.Settings(form);
            elements = new List<Figures.Element>();
        }
    }
}
