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
using System.Reflection;

namespace easyNFT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Point atr1 = new Point(118,166);
            Point atr2 = new Point(118, 255);
            Point atr3 = new Point(118, 342);
            Point atr4 = new Point(118, 431);
            Point atr5 = new Point(118, 518);
            Point atr6 = new Point(118, 607);
            Point atr7 = new Point(118, 694);
            Point atr8 = new Point(118, 781);
            Point atr9 = new Point(118, 868);
            Point atr10 = new Point(118, 936);
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
                int i = 1;
                foreach (String file in dialog.FileNames)
                {
                    Control c = this.Controls.Find("index" + i.ToString() + "Atr10", true).Single();
                    c.Text = System.IO.Path.GetFileName(file);
                    i++;
                }
            }
        }

        //connects the name string to its corresponding control
        public class variableNames : Control{

            Control controlName;
            string name;

            public variableNames(string value)
            {
                this.name = value;
                this.controlName = this.Controls.Find(value, true)[0];
            }

            public Control getControl()
            {
                //getControl(string value){
                //Control result = this.Controls.Find(value, true)[0];
                //return result;}
                return this.controlName;
            }
        }
        static void boundCheckAtr(int atrVal, int indexNum)
        {
 
            for (int i = 1; i < indexNum; i++)
            {
                //currIndexLOW
                string curLowString = String.Format("lowIndex" + i.ToString() + "Atr" + atrVal.ToString());
                variableNames curLowClass = new variableNames(curLowString);
                Control curLowControl = curLowClass.getControl();
                //currIndexHIGH
                string curHighString = String.Format("highIndex" + i.ToString() + "Atr" + atrVal.ToString());
                variableNames curHighClass = new variableNames(curHighString);
                Control curHighControl = curHighClass.getControl();
                //nextIndexLOW
                string nextLowString = String.Format("lowIndex" + (i+1).ToString() + "Atr" + atrVal.ToString());
                variableNames nextLowClass = new variableNames(nextLowString);
                Control nextLowControl = nextLowClass.getControl();
                //prevIndexHIGH
                string prevHighString = String.Format("highIndex" + (i-1).ToString() + "Atr" + atrVal.ToString());
                variableNames prevHighClass = new variableNames(prevHighString);
                Control prevHighControl = prevHighClass.getControl();

                //if currIndexLOW > currIndexHIGH
                if (((NumericUpDown)curLowControl).Value > ((NumericUpDown)curHighControl).Value)
                {
                    //Error
                    MessageBox.Show(curLowString + " is larger than " + curHighString, "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 

                //if currIndexLOW < prevIndexHIGH
                if (((NumericUpDown)curLowControl).Value < ((NumericUpDown)prevHighControl).Value)
                {
                    //Error
                    MessageBox.Show(curLowString + " is less than " + prevHighString, "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //if currentIndexHIGH > nextIndexLOW
                if (((NumericUpDown)curHighControl).Value > ((NumericUpDown)nextLowControl).Value)
                {
                    //Error
                    MessageBox.Show(curLowString + " is larger than " + curHighString, "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
    }
}