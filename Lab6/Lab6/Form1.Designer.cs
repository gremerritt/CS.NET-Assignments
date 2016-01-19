namespace Lab6
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
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Game_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Game_ComputerStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Game});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(50, 29);
            this.Menu_File.Text = "&File";
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(211, 30);
            this.Menu_File_Exit.Text = "&Exit";
            this.Menu_File_Exit.Click += new System.EventHandler(this.Menu_File_Exit_Click);
            // 
            // Menu_Game
            // 
            this.Menu_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Game_New,
            this.Menu_Game_ComputerStart});
            this.Menu_Game.Name = "Menu_Game";
            this.Menu_Game.Size = new System.Drawing.Size(70, 29);
            this.Menu_Game.Text = "&Game";
            // 
            // Menu_Game_New
            // 
            this.Menu_Game_New.Name = "Menu_Game_New";
            this.Menu_Game_New.Size = new System.Drawing.Size(226, 30);
            this.Menu_Game_New.Text = "&New";
            this.Menu_Game_New.Click += new System.EventHandler(this.Menu_Game_New_Click);
            // 
            // Menu_Game_ComputerStart
            // 
            this.Menu_Game_ComputerStart.Name = "Menu_Game_ComputerStart";
            this.Menu_Game_ComputerStart.Size = new System.Drawing.Size(226, 30);
            this.Menu_Game_ComputerStart.Text = "Computer &Starts";
            this.Menu_Game_ComputerStart.Click += new System.EventHandler(this.Menu_Game_ComputerStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 573);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game_New;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game_ComputerStart;
    }
}

