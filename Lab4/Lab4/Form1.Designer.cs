namespace Lab4
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
            this.clear = new System.Windows.Forms.Button();
            this.hints = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(151, 52);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(186, 48);
            this.clear.TabIndex = 0;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // hints
            // 
            this.hints.AutoSize = true;
            this.hints.Location = new System.Drawing.Point(33, 65);
            this.hints.Name = "hints";
            this.hints.Size = new System.Drawing.Size(72, 24);
            this.hints.TabIndex = 1;
            this.hints.Text = "Hints";
            this.hints.UseVisualStyleBackColor = true;
            this.hints.CheckedChanged += new System.EventHandler(this.hints_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 844);
            this.Controls.Add(this.hints);
            this.Controls.Add(this.clear);
            this.Name = "Form1";
            this.Text = "Eight Queens by Greg Merritt";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.CheckBox hints;
    }
}

