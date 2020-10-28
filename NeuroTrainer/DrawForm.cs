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
        Figures.Element element;
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
            if (page != null)
            {
                standard.getCurrentPositionOfCursor(ref x, ref y);
                Figures.Line line = new Figures.Line(page, File.Settings.color, x, y);
                element = line;
            }
            else standard.MessagePageIsNull();
        }

        private void directLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (page != null)
            {
                standard.getCurrentPositionOfCursor(ref x, ref y);
                Figures.DirectLine directLine = new Figures.DirectLine(page, File.Settings.color);
                element = directLine;
            }
            else standard.MessagePageIsNull();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (page != null)
            {
                standard.getCurrentPositionOfCursor(ref x, ref y);
                Figures.Circle circle = new Figures.Circle(page, File.Settings.color);
                element = circle;
            }
            else standard.MessagePageIsNull();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (page != null)
            {
                standard.getCurrentPositionOfCursor(ref x, ref y);
                Figures.Rectangle rectangle = new Figures.Rectangle(page, File.Settings.color);
                element = rectangle;
            }
            else standard.MessagePageIsNull();
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (page != null)
            {
                standard.getCurrentPositionOfCursor(ref x, ref y);
                Figures.Ellipse ellipse = new Figures.Ellipse(page, File.Settings.color);
                element = ellipse;
            }
            else standard.MessagePageIsNull();
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            standard.dragging();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page = new Page(drawing_Form1);
        }

        private void onEdge(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized) this.Cursor = Cursors.SizeWE;
        }

        private void onEdgeVert(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized) this.Cursor = Cursors.SizeNS;
        }

        private void leaveEdge(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        bool isMouseDown = false;
        private void edge_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            standard.getCurrentPositionOfCursor(ref x, ref y);
        }

        private void edge_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        int x1, y1;
        private void edge1_MouseMove(object sender, MouseEventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x1, ref y1);
            if ((isMouseDown && this.Width > this.MinimumSize.Width) || ( isMouseDown && this.Width == this.MinimumSize.Width && this.Location.X >= x1))
            {
                this.Width -= x1 - x;
                if(this.Width != this.MinimumSize.Width) this.Location = new Point(this.Location.X + (x1 - x), this.Location.Y);
            }
            x = x1;
        }

        private void edge4_MouseMove(object sender, MouseEventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x1, ref y1);
            if ((isMouseDown && this.Height > this.MinimumSize.Height) || (this.Height == this.MinimumSize.Height && this.Location.Y >= y1))
            {
                this.Height -= y1 - y;
                if (this.Height != this.MinimumSize.Height) this.Location = new Point(this.Location.X, this.Location.Y + (y1 - y));
            }
            y = y1;
        }

        private void edge2_MouseMove(object sender, MouseEventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x1, ref y1);
            if ((isMouseDown && this.Width > this.MinimumSize.Width) || (this.Width == this.MinimumSize.Width && (this.Location.X + this.Width) <= x1))
            {
                this.Width += x1 - x;
            }
            x = x1;
        }

        private void MoveDrawing(object sender, MouseEventArgs e)
        {
            if(isDraw) element?.Draw(e.X, e.Y);
        }
        bool isDraw = false;
        private void draw_MouseDown(object sender, MouseEventArgs e)
        {
            element?.SetFirstPoint(e.X, e.Y);
            isDraw = true;
        }
        private void draw_MouseUp(object sender, MouseEventArgs e)
        {
            isDraw = false;
        }

        //Colors
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e) => File.Settings.color = Color.Yellow;
        private void blackToolStripMenuItem_Click(object sender, EventArgs e) => File.Settings.color = Color.Black;
        private void redToolStripMenuItem_Click(object sender, EventArgs e) => File.Settings.color = Color.Red;
        private void blueToolStripMenuItem_Click(object sender, EventArgs e) => File.Settings.color = Color.Blue;

        private void edge3_MouseMove(object sender, MouseEventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x1, ref y1);
            if ((isMouseDown && this.Height > this.MinimumSize.Height) || (this.Height == this.MinimumSize.Height && (this.Location.Y + this.Height) <= y1))
            {
                this.Height += y1 - y;
            }
            y = y1;
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standard.getCurrentPositionOfCursor(ref x, ref y);
            Elements.Image image = new Elements.Image();
        }
    }
}
