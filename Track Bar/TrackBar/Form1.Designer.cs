namespace TrackBar
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
            this.label = new System.Windows.Forms.Label();
            this.txtboxIspis = new System.Windows.Forms.TextBox();
            this.trkUnos = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trkUnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(152, 112);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Postavljena vrijednost je: ";
            // 
            // txtboxIspis
            // 
            this.txtboxIspis.Location = new System.Drawing.Point(285, 109);
            this.txtboxIspis.Name = "txtboxIspis";
            this.txtboxIspis.ReadOnly = true;
            this.txtboxIspis.Size = new System.Drawing.Size(100, 20);
            this.txtboxIspis.TabIndex = 4;
            // 
            // trkUnos
            // 
            this.trkUnos.Location = new System.Drawing.Point(52, 58);
            this.trkUnos.Maximum = 100;
            this.trkUnos.Name = "trkUnos";
            this.trkUnos.Size = new System.Drawing.Size(565, 45);
            this.trkUnos.TabIndex = 3;
            this.trkUnos.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkUnos.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 201);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtboxIspis);
            this.Controls.Add(this.trkUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkUnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtboxIspis;
        private System.Windows.Forms.TrackBar trkUnos;
    }
}

