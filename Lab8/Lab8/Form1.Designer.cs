namespace Lab8
{
    partial class slide_show_viewer
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
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.list_files = new System.Windows.Forms.ListBox();
            this.box_files = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.textbox_interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_interval = new System.Windows.Forms.Label();
            this.open_add_files = new System.Windows.Forms.OpenFileDialog();
            this.save_file = new System.Windows.Forms.SaveFileDialog();
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.box_files.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_open,
            this.menu_file_save,
            this.menu_file_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(50, 29);
            this.menu_file.Text = "&File";
            // 
            // menu_file_open
            // 
            this.menu_file_open.Name = "menu_file_open";
            this.menu_file_open.Size = new System.Drawing.Size(224, 30);
            this.menu_file_open.Text = "&Open Collection";
            this.menu_file_open.Click += new System.EventHandler(this.menu_file_open_Click);
            // 
            // menu_file_save
            // 
            this.menu_file_save.Name = "menu_file_save";
            this.menu_file_save.Size = new System.Drawing.Size(224, 30);
            this.menu_file_save.Text = "&Save Collection";
            this.menu_file_save.Click += new System.EventHandler(this.menu_file_save_Click);
            // 
            // menu_file_exit
            // 
            this.menu_file_exit.Name = "menu_file_exit";
            this.menu_file_exit.Size = new System.Drawing.Size(224, 30);
            this.menu_file_exit.Text = "&Exit";
            this.menu_file_exit.Click += new System.EventHandler(this.menu_file_exit_Click);
            // 
            // list_files
            // 
            this.list_files.FormattingEnabled = true;
            this.list_files.ItemHeight = 20;
            this.list_files.Location = new System.Drawing.Point(54, 74);
            this.list_files.Name = "list_files";
            this.list_files.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_files.Size = new System.Drawing.Size(821, 124);
            this.list_files.TabIndex = 1;
            // 
            // box_files
            // 
            this.box_files.Controls.Add(this.button_delete);
            this.box_files.Controls.Add(this.button_add);
            this.box_files.Location = new System.Drawing.Point(54, 245);
            this.box_files.Name = "box_files";
            this.box_files.Size = new System.Drawing.Size(344, 120);
            this.box_files.TabIndex = 2;
            this.box_files.TabStop = false;
            this.box_files.Text = "Files";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(180, 40);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(137, 50);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(23, 40);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(137, 50);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(591, 245);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(137, 50);
            this.button_show.TabIndex = 2;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // textbox_interval
            // 
            this.textbox_interval.Location = new System.Drawing.Point(662, 338);
            this.textbox_interval.Name = "textbox_interval";
            this.textbox_interval.Size = new System.Drawing.Size(66, 26);
            this.textbox_interval.TabIndex = 4;
            this.textbox_interval.Text = "5";
            this.textbox_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.Location = new System.Drawing.Point(587, 338);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(61, 20);
            this.label_interval.TabIndex = 7;
            this.label_interval.Text = "Interval";
            // 
            // open_add_files
            // 
            this.open_add_files.Filter = "*.gif,*.jpg,*.png,*.bmp|*.gif;*.jpg;*.png;*.bmp";
            this.open_add_files.Multiselect = true;
            // 
            // save_file
            // 
            this.save_file.DefaultExt = "pix";
            this.save_file.Filter = "*.pix|*.pix";
            // 
            // open_file
            // 
            this.open_file.Filter = "*.pix|*.pix";
            // 
            // slide_show_viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 430);
            this.Controls.Add(this.label_interval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_interval);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.box_files);
            this.Controls.Add(this.list_files);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "slide_show_viewer";
            this.Text = "Slide Show Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.box_files.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_file_open;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save;
        private System.Windows.Forms.ToolStripMenuItem menu_file_exit;
        private System.Windows.Forms.ListBox list_files;
        private System.Windows.Forms.GroupBox box_files;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.TextBox textbox_interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.OpenFileDialog open_add_files;
        private System.Windows.Forms.SaveFileDialog save_file;
        private System.Windows.Forms.OpenFileDialog open_file;
    }
}

