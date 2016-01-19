namespace Lab7
{
    partial class none
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(none));
            this.label_filename = new System.Windows.Forms.Label();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button_file_browser = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Location = new System.Drawing.Point(63, 59);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(84, 20);
            this.label_filename.TabIndex = 0;
            this.label_filename.Text = "File Name:";
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(67, 83);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(574, 26);
            this.textBox_filename.TabIndex = 1;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(63, 128);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(39, 20);
            this.label_key.TabIndex = 2;
            this.label_key.Text = "Key:";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(67, 152);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(273, 26);
            this.textBox_key.TabIndex = 3;
            // 
            // button_file_browser
            // 
            this.button_file_browser.Image = ((System.Drawing.Image)(resources.GetObject("button_file_browser.Image")));
            this.button_file_browser.Location = new System.Drawing.Point(647, 73);
            this.button_file_browser.Name = "button_file_browser";
            this.button_file_browser.Size = new System.Drawing.Size(57, 47);
            this.button_file_browser.TabIndex = 4;
            this.button_file_browser.UseVisualStyleBackColor = true;
            this.button_file_browser.Click += new System.EventHandler(this.button_file_browser_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(67, 213);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(110, 36);
            this.button_encrypt.TabIndex = 5;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(183, 213);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(110, 36);
            this.button_decrypt.TabIndex = 6;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // none
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 323);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_file_browser);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.label_filename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "none";
            this.Text = "File Encrypt/Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button_file_browser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;

    }
}

