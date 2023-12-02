namespace FirstTaskWinForm
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
            this.timeLbl = new System.Windows.Forms.Label();
            this.BakuBtn = new System.Windows.Forms.Button();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.timeLbl.Location = new System.Drawing.Point(45, 371);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(100);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(0, 13);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLbl.UseWaitCursor = true;
            // 
            // BakuBtn
            // 
            this.BakuBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.BakuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BakuBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BakuBtn.ForeColor = System.Drawing.Color.Magenta;
            this.BakuBtn.Location = new System.Drawing.Point(251, 24);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(75, 23);
            this.BakuBtn.TabIndex = 1;
            this.BakuBtn.Text = "Baku";
            this.BakuBtn.UseVisualStyleBackColor = false;
            this.BakuBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // LondonBtn
            // 
            this.LondonBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.LondonBtn.ForeColor = System.Drawing.Color.Magenta;
            this.LondonBtn.Location = new System.Drawing.Point(437, 24);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(75, 23);
            this.LondonBtn.TabIndex = 2;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = false;
            this.LondonBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FirstTaskWinForm.Properties.Resources.BakuImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 455);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.BakuBtn);
            this.Controls.Add(this.timeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Button LondonBtn;
    }
}

