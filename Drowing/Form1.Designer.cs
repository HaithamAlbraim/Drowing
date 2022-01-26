namespace Drowing
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
            this.radLine = new System.Windows.Forms.RadioButton();
            this.radElips = new System.Windows.Forms.RadioButton();
            this.radRegtangle = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Location = new System.Drawing.Point(143, 12);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(45, 17);
            this.radLine.TabIndex = 1;
            this.radLine.TabStop = true;
            this.radLine.Text = "Line";
            this.radLine.UseVisualStyleBackColor = true;
            this.radLine.Click += new System.EventHandler(this.radLine_Click);
            // 
            // radElips
            // 
            this.radElips.AutoSize = true;
            this.radElips.Location = new System.Drawing.Point(249, 12);
            this.radElips.Name = "radElips";
            this.radElips.Size = new System.Drawing.Size(47, 17);
            this.radElips.TabIndex = 2;
            this.radElips.TabStop = true;
            this.radElips.Text = "Elips";
            this.radElips.UseVisualStyleBackColor = true;
            // 
            // radRegtangle
            // 
            this.radRegtangle.AutoSize = true;
            this.radRegtangle.Location = new System.Drawing.Point(384, 12);
            this.radRegtangle.Name = "radRegtangle";
            this.radRegtangle.Size = new System.Drawing.Size(74, 17);
            this.radRegtangle.TabIndex = 3;
            this.radRegtangle.TabStop = true;
            this.radRegtangle.Text = "Regtangle";
            this.radRegtangle.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(539, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.radRegtangle);
            this.Controls.Add(this.radElips);
            this.Controls.Add(this.radLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.RadioButton radElips;
        private System.Windows.Forms.RadioButton radRegtangle;
        private System.Windows.Forms.Button btnClear;
    }
}

