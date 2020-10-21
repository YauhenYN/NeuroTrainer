using NeuroTrainer.Classes;
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

        }

        private void saveToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void directLineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
