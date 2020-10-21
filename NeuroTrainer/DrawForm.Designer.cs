namespace NeuroTrainer
{
    partial class DrawForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.programName_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RollUp_Image = new System.Windows.Forms.PictureBox();
            this.completeSize_Image = new System.Windows.Forms.PictureBox();
            this.closing_Image = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollUp_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeSize_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closing_Image)).BeginInit();
            this.panel2.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // programName_Label
            // 
            this.programName_Label.AutoSize = true;
            this.programName_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.programName_Label.Location = new System.Drawing.Point(0, 0);
            this.programName_Label.Name = "programName_Label";
            this.programName_Label.Size = new System.Drawing.Size(69, 13);
            this.programName_Label.TabIndex = 0;
            this.programName_Label.Text = "NeuroTrainer";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.RollUp_Image);
            this.panel1.Controls.Add(this.completeSize_Image);
            this.panel1.Controls.Add(this.closing_Image);
            this.panel1.Controls.Add(this.programName_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 22);
            this.panel1.TabIndex = 1;
            // 
            // RollUp_Image
            // 
            this.RollUp_Image.Dock = System.Windows.Forms.DockStyle.Right;
            this.RollUp_Image.Image = global::NeuroTrainer.Properties.Resources.RollUp;
            this.RollUp_Image.Location = new System.Drawing.Point(719, 0);
            this.RollUp_Image.Margin = new System.Windows.Forms.Padding(0);
            this.RollUp_Image.Name = "RollUp_Image";
            this.RollUp_Image.Size = new System.Drawing.Size(27, 22);
            this.RollUp_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RollUp_Image.TabIndex = 3;
            this.RollUp_Image.TabStop = false;
            this.RollUp_Image.Click += new System.EventHandler(this.RollUp_Image_Click);
            // 
            // completeSize_Image
            // 
            this.completeSize_Image.Dock = System.Windows.Forms.DockStyle.Right;
            this.completeSize_Image.Image = global::NeuroTrainer.Properties.Resources.InCompleteSize;
            this.completeSize_Image.Location = new System.Drawing.Point(746, 0);
            this.completeSize_Image.Margin = new System.Windows.Forms.Padding(0);
            this.completeSize_Image.Name = "completeSize_Image";
            this.completeSize_Image.Size = new System.Drawing.Size(27, 22);
            this.completeSize_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.completeSize_Image.TabIndex = 1;
            this.completeSize_Image.TabStop = false;
            this.completeSize_Image.Click += new System.EventHandler(this.completeSize_Image_Click);
            // 
            // closing_Image
            // 
            this.closing_Image.Dock = System.Windows.Forms.DockStyle.Right;
            this.closing_Image.Image = global::NeuroTrainer.Properties.Resources.Closing;
            this.closing_Image.Location = new System.Drawing.Point(773, 0);
            this.closing_Image.Margin = new System.Windows.Forms.Padding(0);
            this.closing_Image.Name = "closing_Image";
            this.closing_Image.Size = new System.Drawing.Size(27, 22);
            this.closing_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closing_Image.TabIndex = 2;
            this.closing_Image.TabStop = false;
            this.closing_Image.Click += new System.EventHandler(this.closing_Image_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TopMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 428);
            this.panel2.TabIndex = 2;
            // 
            // TopMenu
            // 
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.drawToolStripMenuItem,
            this.addToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(800, 24);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uploadToolStripMenuItem1
            // 
            this.uploadToolStripMenuItem1.Name = "uploadToolStripMenuItem1";
            this.uploadToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.uploadToolStripMenuItem1.Text = "Upload";
            this.uploadToolStripMenuItem1.Click += new System.EventHandler(this.uploadToolStripMenuItem1_Click_1);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click_1);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem1.Text = "Save as";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click_1);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.directLineToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.drawToolStripMenuItem.Text = "Draw";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // directLineToolStripMenuItem
            // 
            this.directLineToolStripMenuItem.Name = "directLineToolStripMenuItem";
            this.directLineToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.directLineToolStripMenuItem.Text = "DirectLine";
            this.directLineToolStripMenuItem.Click += new System.EventHandler(this.directLineToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.TopMenu;
            this.Name = "DrawForm";
            this.Text = "DrawForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollUp_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeSize_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closing_Image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label programName_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closing_Image;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox completeSize_Image;
        private System.Windows.Forms.PictureBox RollUp_Image;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
    }
}