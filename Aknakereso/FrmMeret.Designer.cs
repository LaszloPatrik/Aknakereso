namespace Aknakereso
{
    partial class FrmMeret
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
            this.qlb = new System.Windows.Forms.Label();
            this.tbx = new System.Windows.Forms.TextBox();
            this.xlb = new System.Windows.Forms.Label();
            this.ylb = new System.Windows.Forms.Label();
            this.tby = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // qlb
            // 
            this.qlb.AutoSize = true;
            this.qlb.Location = new System.Drawing.Point(12, 9);
            this.qlb.Name = "qlb";
            this.qlb.Size = new System.Drawing.Size(126, 13);
            this.qlb.TabIndex = 0;
            this.qlb.Text = "Mekkora legyen a pálya?";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(35, 32);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(100, 20);
            this.tbx.TabIndex = 1;
            // 
            // xlb
            // 
            this.xlb.AutoSize = true;
            this.xlb.Location = new System.Drawing.Point(12, 35);
            this.xlb.Name = "xlb";
            this.xlb.Size = new System.Drawing.Size(17, 13);
            this.xlb.TabIndex = 2;
            this.xlb.Text = "X:";
            // 
            // ylb
            // 
            this.ylb.AutoSize = true;
            this.ylb.Location = new System.Drawing.Point(12, 74);
            this.ylb.Name = "ylb";
            this.ylb.Size = new System.Drawing.Size(17, 13);
            this.ylb.TabIndex = 3;
            this.ylb.Text = "Y:";
            // 
            // tby
            // 
            this.tby.Location = new System.Drawing.Point(35, 71);
            this.tby.Name = "tby";
            this.tby.Size = new System.Drawing.Size(100, 20);
            this.tby.TabIndex = 4;
            // 
            // FrmMeret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 105);
            this.Controls.Add(this.tby);
            this.Controls.Add(this.ylb);
            this.Controls.Add(this.xlb);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.qlb);
            this.Name = "FrmMeret";
            this.Text = "Meret";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMeret_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qlb;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Label xlb;
        private System.Windows.Forms.Label ylb;
        private System.Windows.Forms.TextBox tby;
    }
}