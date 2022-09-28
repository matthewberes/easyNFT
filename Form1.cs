using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyNFT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtr1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                //int hatNum = dialog.FileNames.Length;
                //label1.Text = hatNum.ToString();
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr1", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr2", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr3", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr4", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr5", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr6", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr7", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr8", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr9_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr9", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        private void btnAtr10_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int hairNum = dialog.FileNames.Length;
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr10", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }
    }
}
