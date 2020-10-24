using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NeuroTrainer.Classes
{
    public static class File
    {
        public class Settings
        {
            Drawing_Form form;
            public static Color color = Color.Black;
            int heigh_Page = 0, width_Page = 0;
            public Settings(Drawing_Form form)
            {
                this.form = form;
                Heigh_Page = 500;
                Width_Page = 500;
            }
            public int Heigh_Page { get { return heigh_Page; } set { if (heigh_Page + value > 299 && heigh_Page + value < 3001) heigh_Page += value; form.Height = heigh_Page; } }
            public int Width_Page { get { return width_Page; } set { if (width_Page + value > 299 && width_Page + value < 3001) width_Page += value; form.Width = Width_Page; } }
        }
        public static void Load()
        {

        }
        public static void Write()
        {

        }
    }
}
