namespace Lab3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.view_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.menu_menu,
            this.view_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear_menu});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(50, 29);
            this.file_menu.Text = "&File";
            // 
            // clear_menu
            // 
            this.clear_menu.Name = "clear_menu";
            this.clear_menu.Size = new System.Drawing.Size(136, 30);
            this.clear_menu.Text = "&Clear";
            this.clear_menu.Click += new System.EventHandler(this.clear_menu_Click);
            // 
            // menu_menu
            // 
            this.menu_menu.Name = "menu_menu";
            this.menu_menu.Size = new System.Drawing.Size(69, 29);
            this.menu_menu.Text = "&Menu";
            // 
            // view_menu
            // 
            this.view_menu.Name = "view_menu";
            this.view_menu.Size = new System.Drawing.Size(61, 29);
            this.view_menu.Text = "&View";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(206, 314);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(261, 58);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 384);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_menu;
        private System.Windows.Forms.ToolStripMenuItem view_menu;
        private System.Windows.Forms.Button clear_button;
    }
}

