using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Threading;

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
            public int Heigh_Page { get { return heigh_Page; } set { if ((value > 299 && value < 1820) || value == 0) heigh_Page = value; form.Height = heigh_Page; } }
            public int Width_Page { get { return width_Page; } set { if ((value > 299 && value < 1080) || value == 0) width_Page = value; form.Width = Width_Page; } }
            ~Settings()
            {
                Heigh_Page = 0;
                Width_Page = 0;
            }
        }
        private static Page load(Drawing_Form form, String path)
        {
            TextReader tr = new StreamReader(path);
            String str = tr.ReadLine();
            tr.Close();
            Integrate integrated = JsonSerializer.Deserialize<Integrate>(str);
            return new Page(form, integrated);
        }
        private static void write(Integrate integrated, String path)
        {
            string wPage = JsonSerializer.Serialize<Integrate>(integrated);
            System.IO.File.WriteAllText(path, wPage);
        }
        static FileDialog fileDialog;
        static string path;
        public static void save(Page page)
        {
            if (page != null)
                if (path != null) write(page.OutIntegrate(), path);
                else StandardMethods.pathIsNull();
            else StandardMethods.messagePageIsNull();
        }
        public static void saveAs(Page page)
        {
            if (page != null)
            {
                fileDialog = new SaveFileDialog();
                fileDialog.DefaultExt = "nt";
                fileDialog.ShowDialog();
                if (fileDialog.FileName != "") write(page.OutIntegrate(), fileDialog.FileName);
            }
        }
        public static Page upload(Drawing_Form form)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "nt";
            fileDialog.ShowDialog();
            if (fileDialog.FileName != "") { path = fileDialog.FileName; return load(form, fileDialog.FileName); }
            else return null;
        }
        public class Integrate
        {
            public int heigh_Drawing_Form { get; set; }
            public int width_Drawing_Form { get; set; }
            public List<List<int>> values { get; set; }
            public List<int> colors { get; set; }
            public List<String> types { get; set; }
            public Integrate()
            {
                values = new List<List<int>>();
                colors = new List<int>();
                types = new List<string>();
            }
        }
    }
}
