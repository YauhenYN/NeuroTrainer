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
            this.header = new System.Windows.Forms.Panel();
            this.edge4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RollUp_Image = new System.Windows.Forms.PictureBox();
            this.completeSize_Image = new System.Windows.Forms.PictureBox();
            this.closing_Image = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edge3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edge1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edge2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawing_Form1 = new NeuroTrainer.Drawing_Form();
            this.header.SuspendLayout();
            this.edge4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollUp_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeSize_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closing_Image)).BeginInit();
            this.panel2.SuspendLayout();
            this.edge3.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.edge1.SuspendLayout();
            this.edge2.SuspendLayout();
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
            // header
            // 
            this.header.AutoScroll = true;
            this.header.Controls.Add(this.edge4);
            this.header.Controls.Add(this.RollUp_Image);
            this.header.Controls.Add(this.completeSize_Image);
            this.header.Controls.Add(this.closing_Image);
            this.header.Controls.Add(this.programName_Label);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 22);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // edge4
            // 
            this.edge4.Controls.Add(this.panel6);
            this.edge4.Dock = System.Windows.Forms.DockStyle.Top;
            this.edge4.Location = new System.Drawing.Point(69, 0);
            this.edge4.Margin = new System.Windows.Forms.Padding(0);
            this.edge4.Name = "edge4";
            this.edge4.Size = new System.Drawing.Size(650, 5);
            this.edge4.TabIndex = 7;
            this.edge4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.edge_MouseDown);
            this.edge4.MouseLeave += new System.EventHandler(this.leaveEdge);
            this.edge4.MouseHover += new System.EventHandler(this.onEdgeVert);
            this.edge4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.edge4_MouseMove);
            this.edge4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.edge_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(790, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 428);
            this.panel6.TabIndex = 3;
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
            this.panel2.Controls.Add(this.drawing_Form1);
            this.panel2.Controls.Add(this.edge3);
            this.panel2.Controls.Add(this.TopMenu);
            this.panel2.Controls.Add(this.edge1);
            this.panel2.Controls.Add(this.edge2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 428);
            this.panel2.TabIndex = 2;
            // 
            // edge3
            // 
            this.edge3.Controls.Add(this.panel5);
            this.edge3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.edge3.Location = new System.Drawing.Point(5, 423);
            this.edge3.Margin = new System.Windows.Forms.Padding(0);
            this.edge3.Name = "edge3";
            this.edge3.Size = new System.Drawing.Size(790, 5);
            this.edge3.TabIndex = 6;
            this.edge3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.edge_MouseDown);
            this.edge3.MouseLeave += new System.EventHandler(this.leaveEdge);
            this.edge3.MouseHover += new System.EventHandler(this.onEdgeVert);
            this.edge3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.edge3_MouseMove);
            this.edge3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.edge_MouseUp);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(790, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 428);
            this.panel5.TabIndex = 3;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.TopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.drawToolStripMenuItem,
            this.addToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(5, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.TopMenu.Size = new System.Drawing.Size(790, 24);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.createToolStripMenuItem});
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
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
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
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // edge1
            // 
            this.edge1.Controls.Add(this.panel1);
            this.edge1.Dock = System.Windows.Forms.DockStyle.Left;
            this.edge1.Location = new System.Drawing.Point(0, 0);
            this.edge1.Margin = new System.Windows.Forms.Padding(0);
            this.edge1.Name = "edge1";
            this.edge1.Size = new System.Drawing.Size(5, 428);
            this.edge1.TabIndex = 2;
            this.edge1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.edge_MouseDown);
            this.edge1.MouseLeave += new System.EventHandler(this.leaveEdge);
            this.edge1.MouseHover += new System.EventHandler(this.onEdge);
            this.edge1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.edge1_MouseMove);
            this.edge1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.edge_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(790, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 428);
            this.panel1.TabIndex = 3;
            // 
            // edge2
            // 
            this.edge2.Controls.Add(this.panel4);
            this.edge2.Dock = System.Windows.Forms.DockStyle.Right;
            this.edge2.Location = new System.Drawing.Point(795, 0);
            this.edge2.Margin = new System.Windows.Forms.Padding(0);
            this.edge2.Name = "edge2";
            this.edge2.Size = new System.Drawing.Size(5, 428);
            this.edge2.TabIndex = 3;
            this.edge2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.edge_MouseDown);
            this.edge2.MouseLeave += new System.EventHandler(this.leaveEdge);
            this.edge2.MouseHover += new System.EventHandler(this.onEdge);
            this.edge2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.edge2_MouseMove);
            this.edge2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.edge_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(790, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 428);
            this.panel4.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // drawing_Form1
            // 
            this.drawing_Form1.BackColor = System.Drawing.SystemColors.Control;
            this.drawing_Form1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawing_Form1.Location = new System.Drawing.Point(5, 24);
            this.drawing_Form1.Margin = new System.Windows.Forms.Padding(0);
            this.drawing_Form1.Name = "drawing_Form1";
            this.drawing_Form1.Size = new System.Drawing.Size(0, 0);
            this.drawing_Form1.TabIndex = 7;
            this.drawing_Form1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draw_MouseDown);
            this.drawing_Form1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveDrawing);
            this.drawing_Form1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.draw_MouseUp);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.TopMenu;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "DrawForm";
            this.Text = "DrawForm";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.edge4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RollUp_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeSize_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closing_Image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.edge3.ResumeLayout(false);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.edge1.ResumeLayout(false);
            this.edge2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label programName_Label;
        private System.Windows.Forms.Panel header;
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
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.Panel edge1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel edge2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel edge3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel edge4;
        private System.Windows.Forms.Panel panel6;
        private Drawing_Form drawing_Form1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
    }
}