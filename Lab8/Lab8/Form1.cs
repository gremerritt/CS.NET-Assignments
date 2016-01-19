using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace Lab8
{
    public partial class slide_show_viewer : Form
    {
        Form modal = new Form();
        System.Windows.Forms.Timer timer;
        int image_index;

        public slide_show_viewer()
        {
            InitializeComponent();
            modal.KeyPress += new KeyPressEventHandler(escape);
            modal.ControlBox = false;
            modal.FormBorderStyle = FormBorderStyle.None;
            modal.WindowState = FormWindowState.Maximized;
            modal.Paint += new PaintEventHandler(modal_paint);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (open_add_files.ShowDialog(this) == DialogResult.OK)
            {
                foreach(String file in open_add_files.FileNames)
                {
                    list_files.Items.Add(file);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < list_files.Items.Count)
            {
                if (list_files.GetSelected(i)) list_files.Items.RemoveAt(i);
                else i++;
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            if (list_files.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No file names to show.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int interval;
            try
            {
                interval = Int32.Parse(textbox_interval.Text);
            }
            catch
            {
                System.Media.SystemSounds.Beep.Play();
                System.Windows.Forms.MessageBox.Show("Please enter an integer time interval > 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (interval < 1)
            {
                System.Media.SystemSounds.Beep.Play();
                System.Windows.Forms.MessageBox.Show("Please enter an integer time interval > 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (interval > 3600)
            {
                System.Media.SystemSounds.Beep.Play();
                System.Windows.Forms.MessageBox.Show("Please enter an integer time interval < 3600.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                image_index = 0;
                modal.Show();

                timer = new System.Windows.Forms.Timer();
                timer.Interval = interval * 1000;
                timer.Enabled = true;
                timer.Tick += new EventHandler(switch_image);
            }
        }

        private void switch_image(Object source, EventArgs e)
        {
            image_index++;
            if (image_index == list_files.Items.Count)
            {
                timer.Dispose();
                modal.Hide();
                return;
            }
            else modal.Invalidate();
        }

        private void modal_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            try
            {
                String image_file = list_files.Items[image_index].ToString();
                Bitmap bm = new Bitmap(image_file);
                SizeF cs = modal.ClientSize;
                float ratio = Math.Min(cs.Height / bm.Height, cs.Width / bm.Width);
                g.DrawImage(bm, (cs.Width - (bm.Width * ratio)) / 2, (cs.Height - (bm.Height * ratio)) / 2, bm.Width * ratio, bm.Height * ratio);
                bm.Dispose();
            }
            catch
            {
                Font font = new Font("Ariel", 48);
                g.DrawString("[Not an image file]", font, Brushes.Black, 20, 20);
                font.Dispose();
            }
            g.Dispose();
        }

        private void escape(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                timer.Dispose();
                modal.Hide();
            }
        }

        private void menu_file_save_Click(object sender, EventArgs e)
        {
            if (list_files.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No file names to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (save_file.ShowDialog(this) == DialogResult.OK)
            {
                FileStream fs = File.Open(save_file.FileName, FileMode.Create, FileAccess.Write);
                for (int i = 0; i < list_files.Items.Count; i++)
                {
                    String s = list_files.Items[i].ToString() + "\r\n";
                    byte[] f = System.Text.Encoding.Unicode.GetBytes(s);
                    fs.Write(f, 0, f.Length);
                }
                fs.Close();
            }
        }

        private void menu_file_open_Click(object sender, EventArgs e)
        {
            if (open_file.ShowDialog(this) == DialogResult.OK)
            {
                FileStream fs = File.Open(open_file.FileName, FileMode.Open, FileAccess.Read);
                byte[] file_contents = new byte[(int)fs.Length];
                fs.Read(file_contents, 0, (int)fs.Length);
                string s = System.Text.Encoding.Unicode.GetString(file_contents, 0, file_contents.Length);
                
                string[] files = s.Split(new string[] {"\r\n"}, StringSplitOptions.None);
                list_files.Items.Clear();
                for (int i = 0; i < files.Length - 1; i++ ) list_files.Items.Add(files[i]);
                fs.Close();
            }
        }

        private void menu_file_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
