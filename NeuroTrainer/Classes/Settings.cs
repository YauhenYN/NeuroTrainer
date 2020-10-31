using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

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
        private static Page Load(String path)
        {
            TextReader tr = new StreamReader(path);
            String str = tr.ReadLine();
            Page page = JsonSerializer.Deserialize<Page>(str);
            return page;
        }
        private static void Write(Page page, String path)
        {
            string wPage = JsonSerializer.Serialize<Page>(page);
            FileStream fileStream = new FileStream(path, FileMode.Create);
            StreamWriter output = new StreamWriter(fileStream);
            output.Write(wPage);
        }
        public static void save(Page page)
        {

        }
        public static void saveAs(Page page)
        {

        }
        public static Page upload()
        {
            return new Page(new Drawing_Form());
        }
    }
}
