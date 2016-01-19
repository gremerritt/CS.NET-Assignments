namespace Lab5
{
    partial class Lab5
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
            this.Panel_Drawing_Area = new System.Windows.Forms.Panel();
            this.Draw_Box = new System.Windows.Forms.GroupBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Radio_Text = new System.Windows.Forms.RadioButton();
            this.Radio_Ellipse = new System.Windows.Forms.RadioButton();
            this.Radio_Rectangle = new System.Windows.Forms.RadioButton();
            this.Radio_Line = new System.Windows.Forms.RadioButton();
            this.Select_Pen_Color = new System.Windows.Forms.ListBox();
            this.Select_Fill_Color = new System.Windows.Forms.ListBox();
            this.Select_Pen_Width = new System.Windows.Forms.ListBox();
            this.Checkbox_Fill = new System.Windows.Forms.CheckBox();
            this.Checkbox_Outline = new System.Windows.Forms.CheckBox();
            this.Label_Pen_Color = new System.Windows.Forms.Label();
            this.Label_Fill_Color = new System.Windows.Forms.Label();
            this.Label_Pen_Width = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Draw_Box.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Drawing_Area
            // 
            this.Panel_Drawing_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Drawing_Area.BackColor = System.Drawing.SystemColors.Window;
            this.Panel_Drawing_Area.Location = new System.Drawing.Point(0, 336);
            this.Panel_Drawing_Area.Name = "Panel_Drawing_Area";
            this.Panel_Drawing_Area.Size = new System.Drawing.Size(1025, 360);
            this.Panel_Drawing_Area.TabIndex = 1;
            this.Panel_Drawing_Area.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Drawing_Area_Paint);
            this.Panel_Drawing_Area.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Drawing_Area_MouseClick);
            // 
            // Draw_Box
            // 
            this.Draw_Box.Controls.Add(this.TextBox);
            this.Draw_Box.Controls.Add(this.Radio_Text);
            this.Draw_Box.Controls.Add(this.Radio_Ellipse);
            this.Draw_Box.Controls.Add(this.Radio_Rectangle);
            this.Draw_Box.Controls.Add(this.Radio_Line);
            this.Draw_Box.Location = new System.Drawing.Point(29, 40);
            this.Draw_Box.Name = "Draw_Box";
            this.Draw_Box.Size = new System.Drawing.Size(292, 270);
            this.Draw_Box.TabIndex = 1;
            this.Draw_Box.TabStop = false;
            this.Draw_Box.Text = "Draw";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(43, 145);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(243, 119);
            this.TextBox.TabIndex = 4;
            this.TextBox.WordWrap = false;
            // 
            // Radio_Text
            // 
            this.Radio_Text.AutoSize = true;
            this.Radio_Text.Location = new System.Drawing.Point(43, 115);
            this.Radio_Text.Name = "Radio_Text";
            this.Radio_Text.Size = new System.Drawing.Size(64, 24);
            this.Radio_Text.TabIndex = 3;
            this.Radio_Text.TabStop = true;
            this.Radio_Text.Text = "Text";
            this.Radio_Text.UseVisualStyleBackColor = true;
            // 
            // Radio_Ellipse
            // 
            this.Radio_Ellipse.AutoSize = true;
            this.Radio_Ellipse.Location = new System.Drawing.Point(43, 85);
            this.Radio_Ellipse.Name = "Radio_Ellipse";
            this.Radio_Ellipse.Size = new System.Drawing.Size(80, 24);
            this.Radio_Ellipse.TabIndex = 2;
            this.Radio_Ellipse.TabStop = true;
            this.Radio_Ellipse.Text = "Ellipse";
            this.Radio_Ellipse.UseVisualStyleBackColor = true;
            // 
            // Radio_Rectangle
            // 
            this.Radio_Rectangle.AutoSize = true;
            this.Radio_Rectangle.Location = new System.Drawing.Point(43, 55);
            this.Radio_Rectangle.Name = "Radio_Rectangle";
            this.Radio_Rectangle.Size = new System.Drawing.Size(107, 24);
            this.Radio_Rectangle.TabIndex = 1;
            this.Radio_Rectangle.TabStop = true;
            this.Radio_Rectangle.Text = "Rectangle";
            this.Radio_Rectangle.UseVisualStyleBackColor = true;
            // 
            // Radio_Line
            // 
            this.Radio_Line.AutoSize = true;
            this.Radio_Line.Location = new System.Drawing.Point(43, 25);
            this.Radio_Line.Name = "Radio_Line";
            this.Radio_Line.Size = new System.Drawing.Size(64, 24);
            this.Radio_Line.TabIndex = 0;
            this.Radio_Line.TabStop = true;
            this.Radio_Line.Text = "Line";
            this.Radio_Line.UseVisualStyleBackColor = true;
            // 
            // Select_Pen_Color
            // 
            this.Select_Pen_Color.FormattingEnabled = true;
            this.Select_Pen_Color.ItemHeight = 20;
            this.Select_Pen_Color.Location = new System.Drawing.Point(364, 80);
            this.Select_Pen_Color.Name = "Select_Pen_Color";
            this.Select_Pen_Color.Size = new System.Drawing.Size(120, 84);
            this.Select_Pen_Color.TabIndex = 3;
            // 
            // Select_Fill_Color
            // 
            this.Select_Fill_Color.FormattingEnabled = true;
            this.Select_Fill_Color.ItemHeight = 20;
            this.Select_Fill_Color.Location = new System.Drawing.Point(535, 80);
            this.Select_Fill_Color.Name = "Select_Fill_Color";
            this.Select_Fill_Color.Size = new System.Drawing.Size(120, 104);
            this.Select_Fill_Color.TabIndex = 4;
            // 
            // Select_Pen_Width
            // 
            this.Select_Pen_Width.FormattingEnabled = true;
            this.Select_Pen_Width.ItemHeight = 20;
            this.Select_Pen_Width.Location = new System.Drawing.Point(710, 79);
            this.Select_Pen_Width.Name = "Select_Pen_Width";
            this.Select_Pen_Width.Size = new System.Drawing.Size(120, 204);
            this.Select_Pen_Width.TabIndex = 5;
            // 
            // Checkbox_Fill
            // 
            this.Checkbox_Fill.AutoSize = true;
            this.Checkbox_Fill.Location = new System.Drawing.Point(535, 219);
            this.Checkbox_Fill.Name = "Checkbox_Fill";
            this.Checkbox_Fill.Size = new System.Drawing.Size(54, 24);
            this.Checkbox_Fill.TabIndex = 6;
            this.Checkbox_Fill.Text = "Fill";
            this.Checkbox_Fill.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Outline
            // 
            this.Checkbox_Outline.AutoSize = true;
            this.Checkbox_Outline.Location = new System.Drawing.Point(535, 249);
            this.Checkbox_Outline.Name = "Checkbox_Outline";
            this.Checkbox_Outline.Size = new System.Drawing.Size(85, 24);
            this.Checkbox_Outline.TabIndex = 7;
            this.Checkbox_Outline.Text = "Outline";
            this.Checkbox_Outline.UseVisualStyleBackColor = true;
            // 
            // Label_Pen_Color
            // 
            this.Label_Pen_Color.AutoSize = true;
            this.Label_Pen_Color.Location = new System.Drawing.Point(360, 54);
            this.Label_Pen_Color.Name = "Label_Pen_Color";
            this.Label_Pen_Color.Size = new System.Drawing.Size(78, 20);
            this.Label_Pen_Color.TabIndex = 8;
            this.Label_Pen_Color.Text = "Pen Color";
            // 
            // Label_Fill_Color
            // 
            this.Label_Fill_Color.AutoSize = true;
            this.Label_Fill_Color.Location = new System.Drawing.Point(531, 54);
            this.Label_Fill_Color.Name = "Label_Fill_Color";
            this.Label_Fill_Color.Size = new System.Drawing.Size(69, 20);
            this.Label_Fill_Color.TabIndex = 9;
            this.Label_Fill_Color.Text = "Fill Color";
            // 
            // Label_Pen_Width
            // 
            this.Label_Pen_Width.AutoSize = true;
            this.Label_Pen_Width.Location = new System.Drawing.Point(706, 56);
            this.Label_Pen_Width.Name = "Label_Pen_Width";
            this.Label_Pen_Width.Size = new System.Drawing.Size(82, 20);
            this.Label_Pen_Width.TabIndex = 10;
            this.Label_Pen_Width.Text = "Pen Width";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.Draw_Box);
            this.panel1.Controls.Add(this.Label_Pen_Width);
            this.panel1.Controls.Add(this.Select_Pen_Color);
            this.panel1.Controls.Add(this.Label_Fill_Color);
            this.panel1.Controls.Add(this.Select_Fill_Color);
            this.panel1.Controls.Add(this.Label_Pen_Color);
            this.panel1.Controls.Add(this.Select_Pen_Width);
            this.panel1.Controls.Add(this.Checkbox_Outline);
            this.panel1.Controls.Add(this.Checkbox_Fill);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 341);
            this.panel1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_Clear,
            this.Menu_File_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(50, 29);
            this.Menu_File.Text = "&File";
            // 
            // Menu_File_Clear
            // 
            this.Menu_File_Clear.Name = "Menu_File_Clear";
            this.Menu_File_Clear.Size = new System.Drawing.Size(136, 30);
            this.Menu_File_Clear.Text = "&Clear";
            this.Menu_File_Clear.Click += new System.EventHandler(this.Menu_File_Clear_Click);
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(136, 30);
            this.Menu_File_Exit.Text = "&Exit";
            this.Menu_File_Exit.Click += new System.EventHandler(this.Menu_File_Exit_Click);
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Edit_Undo});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(54, 29);
            this.Menu_Edit.Text = "&Edit";
            // 
            // Menu_Edit_Undo
            // 
            this.Menu_Edit_Undo.Name = "Menu_Edit_Undo";
            this.Menu_Edit_Undo.Size = new System.Drawing.Size(141, 30);
            this.Menu_Edit_Undo.Text = "&Undo";
            this.Menu_Edit_Undo.Click += new System.EventHandler(this.Menu_Edit_Undo_Click);
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1022, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Drawing_Area);
            this.Name = "Lab5";
            this.Text = "Lab 5";
            this.Draw_Box.ResumeLayout(false);
            this.Draw_Box.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Drawing_Area;
        private System.Windows.Forms.GroupBox Draw_Box;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.RadioButton Radio_Text;
        private System.Windows.Forms.RadioButton Radio_Ellipse;
        private System.Windows.Forms.RadioButton Radio_Rectangle;
        private System.Windows.Forms.RadioButton Radio_Line;
        private System.Windows.Forms.ListBox Select_Pen_Color;
        private System.Windows.Forms.ListBox Select_Fill_Color;
        private System.Windows.Forms.ListBox Select_Pen_Width;
        private System.Windows.Forms.CheckBox Checkbox_Fill;
        private System.Windows.Forms.CheckBox Checkbox_Outline;
        private System.Windows.Forms.Label Label_Pen_Color;
        private System.Windows.Forms.Label Label_Fill_Color;
        private System.Windows.Forms.Label Label_Pen_Width;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Clear;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Undo;

    }
}

