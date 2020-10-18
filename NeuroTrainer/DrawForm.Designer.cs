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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollUp_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeSize_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closing_Image)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programName_Label
            // 
            this.programName_Label.AutoSize = true;
            this.programName_Label.Location = new System.Drawing.Point(3, 10);
            this.programName_Label.Name = "programName_Label";
            this.programName_Label.Size = new System.Drawing.Size(69, 13);
            this.programName_Label.TabIndex = 0;
            this.programName_Label.Text = "NeuroTrainer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RollUp_Image);
            this.panel1.Controls.Add(this.completeSize_Image);
            this.panel1.Controls.Add(this.closing_Image);
            this.panel1.Controls.Add(this.programName_Label);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 26);
            this.panel1.TabIndex = 1;
            // 
            // RollUp_Image
            // 
            this.RollUp_Image.Image = global::NeuroTrainer.Properties.Resources.RollUp;
            this.RollUp_Image.Location = new System.Drawing.Point(720, 1);
            this.RollUp_Image.Margin = new System.Windows.Forms.Padding(0);
            this.RollUp_Image.Name = "RollUp_Image";
            this.RollUp_Image.Size = new System.Drawing.Size(27, 25);
            this.RollUp_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RollUp_Image.TabIndex = 3;
            this.RollUp_Image.TabStop = false;
            this.RollUp_Image.Click += new System.EventHandler(this.RollUp_Image_Click);
            // 
            // completeSize_Image
            // 
            this.completeSize_Image.Image = global::NeuroTrainer.Properties.Resources.InCompleteSize;
            this.completeSize_Image.Location = new System.Drawing.Point(747, 1);
            this.completeSize_Image.Margin = new System.Windows.Forms.Padding(0);
            this.completeSize_Image.Name = "completeSize_Image";
            this.completeSize_Image.Size = new System.Drawing.Size(27, 25);
            this.completeSize_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.completeSize_Image.TabIndex = 1;
            this.completeSize_Image.TabStop = false;
            this.completeSize_Image.Click += new System.EventHandler(this.completeSize_Image_Click);
            // 
            // closing_Image
            // 
            this.closing_Image.Image = global::NeuroTrainer.Properties.Resources.Closing;
            this.closing_Image.Location = new System.Drawing.Point(774, 1);
            this.closing_Image.Margin = new System.Windows.Forms.Padding(0);
            this.closing_Image.Name = "closing_Image";
            this.closing_Image.Size = new System.Drawing.Size(27, 25);
            this.closing_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closing_Image.TabIndex = 2;
            this.closing_Image.TabStop = false;
            this.closing_Image.Click += new System.EventHandler(this.closing_Image_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(-1, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 425);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawForm";
            this.Text = "DrawForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollUp_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeSize_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closing_Image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label programName_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closing_Image;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox completeSize_Image;
        private System.Windows.Forms.PictureBox RollUp_Image;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}