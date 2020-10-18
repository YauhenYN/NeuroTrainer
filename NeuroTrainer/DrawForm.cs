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
        StandartMethods standart = new StandartMethods();
        public DrawForm()
        {
            InitializeComponent();
        }

        private void closing_Image_Click(object sender, EventArgs e)
        {
            standart.closing();
            Application.Exit();
        }

        private void completeSize_Image_Click(object sender, EventArgs e)
        {
            standart.CompleteSize();
        }

        private void RollUp_Image_Click(object sender, EventArgs e)
        {
            standart.rollUp();
        }
    }
}
