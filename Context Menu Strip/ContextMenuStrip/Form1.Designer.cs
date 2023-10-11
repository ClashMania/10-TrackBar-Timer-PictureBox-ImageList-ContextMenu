namespace ContextMenuStrip
{
    partial class Form1
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
            this.textBoxLijevo = new System.Windows.Forms.TextBox();
            this.textBoxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLijevo
            // 
            this.textBoxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxLijevo.Location = new System.Drawing.Point(46, 38);
            this.textBoxLijevo.Name = "textBoxLijevo";
            this.textBoxLijevo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLijevo.TabIndex = 0;
            // 
            // textBoxDesno
            // 
            this.textBoxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxDesno.Location = new System.Drawing.Point(250, 38);
            this.textBoxDesno.Name = "textBoxDesno";
            this.textBoxDesno.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesno.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 48);
            // 
            // lijevoNaDesnoToolStripMenuItem
            // 
            this.lijevoNaDesnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlToolStripMenuItem,
            this.ctrlLToolStripMenuItem});
            this.lijevoNaDesnoToolStripMenuItem.Name = "lijevoNaDesnoToolStripMenuItem";
            this.lijevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.lijevoNaDesnoToolStripMenuItem.Text = "Lijevo na Desno";
            // 
            // desnoNaLijevoToolStripMenuItem
            // 
            this.desnoNaLijevoToolStripMenuItem.Name = "desnoNaLijevoToolStripMenuItem";
            this.desnoNaLijevoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.desnoNaLijevoToolStripMenuItem.Text = "Desno na Lijevo";
            // 
            // ctrlToolStripMenuItem
            // 
            this.ctrlToolStripMenuItem.Name = "ctrlToolStripMenuItem";
            this.ctrlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ctrlToolStripMenuItem.Text = "Ctrl + D";
            // 
            // ctrlLToolStripMenuItem
            // 
            this.ctrlLToolStripMenuItem.Name = "ctrlLToolStripMenuItem";
            this.ctrlLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ctrlLToolStripMenuItem.Text = "Ctrl + L";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.Controls.Add(this.textBoxDesno);
            this.Controls.Add(this.textBoxLijevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLijevo;
        private System.Windows.Forms.TextBox textBoxDesno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoToolStripMenuItem;
    }
}

