using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Collections;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace Lab7
{
    public partial class none : Form
    {
        public none()
        {
            InitializeComponent();
        }

        private void button_file_browser_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this)==DialogResult.OK)
            {
                textBox_filename.Text=openFileDialog.FileName;
            }
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            if (!key_was_entered()) return;
            byte[] key = generate_key(textBox_key.Text);
            encrypt_file(textBox_filename.Text, key);
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            if (!key_was_entered()) return;
            byte[] key = generate_key(textBox_key.Text);
            decrypt_file(textBox_filename.Text, key);
        }

        private bool key_was_entered()
        {
            if (textBox_key.TextLength == 0)
            {
                System.Media.SystemSounds.Beep.Play();
                System.Windows.Forms.MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private byte[] generate_key(String s)
        {
            byte[] key = new byte[8] {0,0,0,0,0,0,0,0};
            int key_index = 0;

            foreach(char c in s)
            {
                byte b = (byte)c;
                
                key[key_index++] += b;
                if (key_index > 7) key_index = 0;
            }

            return key;
        }

        private void encrypt_file(string file, byte[] key)
        {
            FileStream fs_source_file;
            FileStream fs_target_file;
            try
            {
                if (File.Exists(file + ".des"))
                {
                    if (System.Windows.Forms.MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
                }
                fs_source_file = new FileStream(file, FileMode.Open, FileAccess.Read);
                fs_target_file = new FileStream(file + ".des", FileMode.Create, FileAccess.Write);
            }
            catch
            {
                System.Media.SystemSounds.Beep.Play();
                System.Windows.Forms.MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = key;
            DES.IV = key;
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fs_target_file, desencrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fs_source_file.Length];
            fs_source_file.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fs_source_file.Close();
            fs_target_file.Close();
        }

        void decrypt_file(string file, byte[] key)
        {
            FileStream fs_source_file;
            StreamWriter fs_target_file;
            string target_filepath = Path.GetDirectoryName(file) + '\\' + Path.GetFileNameWithoutExtension(file);
            try
            {
                if (Path.GetExtension(file) != ".des")
                {
                    System.Windows.Forms.MessageBox.Show("Not a .des file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                fs_source_file = new FileStream(file, FileMode.Open, FileAccess.Read);
                fs_target_file = new StreamWriter(target_filepath);
            }
            catch
            {
                System.Media.SystemSounds.Beep.Play();
                System.Windows.Forms.MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = key;
            DES.IV = key;
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            CryptoStream cryptostreamDecr = new CryptoStream(fs_source_file, desdecrypt, CryptoStreamMode.Read);
            try {
                String s = new StreamReader(cryptostreamDecr).ReadToEnd();
                fs_target_file.Write(s);
                fs_target_file.Flush();
                fs_target_file.Close();
                fs_source_file.Close();
            }
            catch
            {
                fs_target_file.Flush();
                fs_target_file.Close();
                fs_source_file.Close();
                File.Delete(target_filepath);
                System.Windows.Forms.MessageBox.Show("Invalid key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        } 
    }
}
