using NeuroTrainer.Classes;
using NeuroTrainer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroTrainer
{
    public partial class DrawForm : Form
    {
        StandardMethods standard;
        Page page;
        public DrawForm()
        {
            InitializeComponent();
            standard = new StandardMethods(this);
        }

        private void closing_Image_Click(object sender, EventArgs e)
        {
            standard.closing();
            Application.Exit();
        }

        private void completeSize_Image_Click(object sender, EventArgs e)
        {
            standard.completeSize();
        }

        private void RollUp_Image_Click(object sender, EventArgs e)
        {
            standard.rollUp();
        }

        private void uploadToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            File.Load();
        }

        private void saveToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }
        int x, y;
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x, ref y);
            Figures.Line line = new Figures.Line(page, File.Settings.color, x, y);
        }

        private void directLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x, ref y);
            Figures.DirectLine directLine = new Figures.DirectLine(page, File.Settings.color, x, y);
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x, ref y);
            Figures.Circle circle = new Figures.Circle(page, File.Settings.color, x, y);
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x, ref y);
            Figures.Rectangle rectangle = new Figures.Rectangle(page, File.Settings.color, x, y);
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x, ref y);
            Figures.Ellipse ellipse = new Figures.Ellipse(page, File.Settings.color, x, y);
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            standard.dragging();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page = new Page(drawing_Form);
        }

        private void onEdge(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeWE; //NoMove
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x, ref y);
            Elements.Image image = new Elements.Image();
        }
    }
}
