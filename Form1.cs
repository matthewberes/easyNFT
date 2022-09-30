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
        class numberInput : NumericUpDown {}
        //numberInput.Increment = 0.01M;

        static void Main()
        {
            //strongly typed language = no dynamic headers :/
            Dictionary<string, string> names = new Dictionary<string, string>();

            //lows
            names["lowIndex1Atr1"] = "lowIndex1Atr1";
            names["lowIndex2Atr1"] = "lowIndex2Atr1";
            names["lowIndex3Atr1"] = "lowIndex3Atr1";
            names["lowIndex4Atr1"] = "lowIndex4Atr1";
            names["lowIndex5Atr1"] = "lowIndex5Atr1";
            names["lowIndex6Atr1"] = "lowIndex6Atr1";
            names["lowIndex7Atr1"] = "lowIndex7Atr1";
            names["lowIndex8Atr1"] = "lowIndex8Atr1";
            names["lowIndex9Atr1"] = "lowIndex9Atr1";
            names["lowIndex10Atr1"] = "lowIndex10Atr1";

            names["lowIndex1Atr2"] = "lowIndex1Atr2";
            names["lowIndex2Atr2"] = "lowIndex2Atr2";
            names["lowIndex3Atr2"] = "lowIndex3Atr2";
            names["lowIndex4Atr2"] = "lowIndex4Atr2";
            names["lowIndex5Atr2"] = "lowIndex5Atr2";
            names["lowIndex6Atr2"] = "lowIndex6Atr2";
            names["lowIndex7Atr2"] = "lowIndex7Atr2";
            names["lowIndex8Atr2"] = "lowIndex8Atr2";
            names["lowIndex9Atr2"] = "lowIndex9Atr2";
            names["lowIndex10Atr2"] = "lowIndex10Atr2";

            names["lowIndex1Atr3"] = "lowIndex1Atr3";
            names["lowIndex2Atr3"] = "lowIndex2Atr3";
            names["lowIndex3Atr3"] = "lowIndex3Atr3";
            names["lowIndex4Atr3"] = "lowIndex4Atr3";
            names["lowIndex5Atr3"] = "lowIndex5Atr3";
            names["lowIndex6Atr3"] = "lowIndex6Atr3";
            names["lowIndex7Atr3"] = "lowIndex7Atr3";
            names["lowIndex8Atr3"] = "lowIndex8Atr3";
            names["lowIndex9Atr3"] = "lowIndex9Atr3";
            names["lowIndex10Atr3"] = "lowIndex10Atr3";

            names["lowIndex1Atr4"] = "lowIndex1Atr4";
            names["lowIndex2Atr4"] = "lowIndex2Atr4";
            names["lowIndex3Atr4"] = "lowIndex3Atr4";
            names["lowIndex4Atr4"] = "lowIndex4Atr4";
            names["lowIndex5Atr4"] = "lowIndex5Atr4";
            names["lowIndex6Atr4"] = "lowIndex6Atr4";
            names["lowIndex7Atr4"] = "lowIndex7Atr4";
            names["lowIndex8Atr4"] = "lowIndex8Atr4";
            names["lowIndex9Atr4"] = "lowIndex9Atr4";
            names["lowIndex10Atr4"] = "lowIndex10Atr4";

            names["lowIndex1Atr5"] = "lowIndex1Atr5";
            names["lowIndex2Atr5"] = "lowIndex2Atr5";
            names["lowIndex3Atr5"] = "lowIndex3Atr5";
            names["lowIndex4Atr5"] = "lowIndex4Atr5";
            names["lowIndex5Atr5"] = "lowIndex5Atr5";
            names["lowIndex6Atr5"] = "lowIndex6Atr5";
            names["lowIndex7Atr5"] = "lowIndex7Atr5";
            names["lowIndex8Atr5"] = "lowIndex8Atr5";
            names["lowIndex9Atr5"] = "lowIndex9Atr5";
            names["lowIndex10Atr5"] = "lowIndex10Atr5";

            names["lowIndex1Atr6"] = "lowIndex1Atr6";
            names["lowIndex2Atr6"] = "lowIndex2Atr6";
            names["lowIndex3Atr6"] = "lowIndex3Atr6";
            names["lowIndex4Atr6"] = "lowIndex4Atr6";
            names["lowIndex5Atr6"] = "lowIndex5Atr6";
            names["lowIndex6Atr6"] = "lowIndex6Atr6";
            names["lowIndex7Atr6"] = "lowIndex7Atr6";
            names["lowIndex8Atr6"] = "lowIndex8Atr6";
            names["lowIndex9Atr6"] = "lowIndex9Atr6";
            names["lowIndex10Atr6"] = "lowIndex10Atr6";

            names["lowIndex1Atr7"] = "lowIndex1Atr7";
            names["lowIndex2Atr7"] = "lowIndex2Atr7";
            names["lowIndex3Atr7"] = "lowIndex3Atr7";
            names["lowIndex4Atr7"] = "lowIndex4Atr7";
            names["lowIndex5Atr7"] = "lowIndex5Atr7";
            names["lowIndex6Atr7"] = "lowIndex6Atr7";
            names["lowIndex7Atr7"] = "lowIndex7Atr7";
            names["lowIndex8Atr7"] = "lowIndex8Atr7";
            names["lowIndex9Atr7"] = "lowIndex9Atr7";
            names["lowIndex10Atr7"] = "lowIndex10Atr7";

            names["lowIndex1Atr8"] = "lowIndex1Atr8";
            names["lowIndex2Atr8"] = "lowIndex2Atr8";
            names["lowIndex3Atr8"] = "lowIndex3Atr8";
            names["lowIndex4Atr8"] = "lowIndex4Atr8";
            names["lowIndex5Atr8"] = "lowIndex5Atr8";
            names["lowIndex6Atr8"] = "lowIndex6Atr8";
            names["lowIndex7Atr8"] = "lowIndex7Atr8";
            names["lowIndex8Atr8"] = "lowIndex8Atr8";
            names["lowIndex9Atr8"] = "lowIndex9Atr8";
            names["lowIndex10Atr8"] = "lowIndex10Atr8";

            names["lowIndex1Atr9"] = "lowIndex1Atr9";
            names["lowIndex2Atr9"] = "lowIndex2Atr9";
            names["lowIndex3Atr9"] = "lowIndex3Atr9";
            names["lowIndex4Atr9"] = "lowIndex4Atr9";
            names["lowIndex5Atr9"] = "lowIndex5Atr9";
            names["lowIndex6Atr9"] = "lowIndex6Atr9";
            names["lowIndex7Atr9"] = "lowIndex7Atr9";
            names["lowIndex8Atr9"] = "lowIndex8Atr9";
            names["lowIndex9Atr9"] = "lowIndex9Atr9";
            names["lowIndex10Atr9"] = "lowIndex10Atr9";

            names["lowIndex1Atr10"] = "lowIndex1Atr10";
            names["lowIndex2Atr10"] = "lowIndex2Atr10";
            names["lowIndex3Atr10"] = "lowIndex3Atr10";
            names["lowIndex4Atr10"] = "lowIndex4Atr10";
            names["lowIndex5Atr10"] = "lowIndex5Atr10";
            names["lowIndex6Atr10"] = "lowIndex6Atr10";
            names["lowIndex7Atr10"] = "lowIndex7Atr10";
            names["lowIndex8Atr10"] = "lowIndex8Atr10";
            names["lowIndex9Atr10"] = "lowIndex9Atr10";
            names["lowIndex10Atr10"] = "lowIndex10Atr10";

            //highs
            names["highIndex1Atr1"] = "highIndex1Atr1";
            names["highIndex2Atr1"] = "highIndex2Atr1";
            names["highIndex3Atr1"] = "highIndex3Atr1";
            names["highIndex4Atr1"] = "highIndex4Atr1";
            names["highIndex5Atr1"] = "highIndex5Atr1";
            names["highIndex6Atr1"] = "highIndex6Atr1";
            names["highIndex7Atr1"] = "highIndex7Atr1";
            names["highIndex8Atr1"] = "highIndex8Atr1";
            names["highIndex9Atr1"] = "highIndex9Atr1";
            names["highIndex10Atr1"] = "highIndex10Atr1";

            names["highIndex1Atr2"] = "highIndex1Atr2";
            names["highIndex2Atr2"] = "highIndex2Atr2";
            names["highIndex3Atr2"] = "highIndex3Atr2";
            names["highIndex4Atr2"] = "highIndex4Atr2";
            names["highIndex5Atr2"] = "highIndex5Atr2";
            names["highIndex6Atr2"] = "highIndex6Atr2";
            names["highIndex7Atr2"] = "highIndex7Atr2";
            names["highIndex8Atr2"] = "highIndex8Atr2";
            names["highIndex9Atr2"] = "highIndex9Atr2";
            names["highIndex10Atr2"] = "highIndex10Atr2";

            names["highIndex1Atr3"] = "highIndex1Atr3";
            names["highIndex2Atr3"] = "highIndex2Atr3";
            names["highIndex3Atr3"] = "highIndex3Atr3";
            names["highIndex4Atr3"] = "highIndex4Atr3";
            names["highIndex5Atr3"] = "highIndex5Atr3";
            names["highIndex6Atr3"] = "highIndex6Atr3";
            names["highIndex7Atr3"] = "highIndex7Atr3";
            names["highIndex8Atr3"] = "highIndex8Atr3";
            names["highIndex9Atr3"] = "highIndex9Atr3";
            names["highIndex10Atr3"] = "highIndex10Atr3";

            names["highIndex1Atr4"] = "highIndex1Atr4";
            names["highIndex2Atr4"] = "highIndex2Atr4";
            names["highIndex3Atr4"] = "highIndex3Atr4";
            names["highIndex4Atr4"] = "highIndex4Atr4";
            names["highIndex5Atr4"] = "highIndex5Atr4";
            names["highIndex6Atr4"] = "highIndex6Atr4";
            names["highIndex7Atr4"] = "highIndex7Atr4";
            names["highIndex8Atr4"] = "highIndex8Atr4";
            names["highIndex9Atr4"] = "highIndex9Atr4";
            names["highIndex10Atr4"] = "highIndex10Atr4";

            names["highIndex1Atr5"] = "highIndex1Atr5";
            names["highIndex2Atr5"] = "highIndex2Atr5";
            names["highIndex3Atr5"] = "highIndex3Atr5";
            names["highIndex4Atr5"] = "highIndex4Atr5";
            names["highIndex5Atr5"] = "highIndex5Atr5";
            names["highIndex6Atr5"] = "highIndex6Atr5";
            names["highIndex7Atr5"] = "highIndex7Atr5";
            names["highIndex8Atr5"] = "highIndex8Atr5";
            names["highIndex9Atr5"] = "highIndex9Atr5";
            names["highIndex10Atr5"] = "highIndex10Atr5";

            names["highIndex1Atr6"] = "highIndex1Atr6";
            names["highIndex2Atr6"] = "highIndex2Atr6";
            names["highIndex3Atr6"] = "highIndex3Atr6";
            names["highIndex4Atr6"] = "highIndex4Atr6";
            names["highIndex5Atr6"] = "highIndex5Atr6";
            names["highIndex6Atr6"] = "highIndex6Atr6";
            names["highIndex7Atr6"] = "highIndex7Atr6";
            names["highIndex8Atr6"] = "highIndex8Atr6";
            names["highIndex9Atr6"] = "highIndex9Atr6";
            names["highIndex10Atr6"] = "highIndex10Atr6";

            names["highIndex1Atr7"] = "highIndex1Atr7";
            names["highIndex2Atr7"] = "highIndex2Atr7";
            names["highIndex3Atr7"] = "highIndex3Atr7";
            names["highIndex4Atr7"] = "highIndex4Atr7";
            names["highIndex5Atr7"] = "highIndex5Atr7";
            names["highIndex6Atr7"] = "highIndex6Atr7";
            names["highIndex7Atr7"] = "highIndex7Atr7";
            names["highIndex8Atr7"] = "highIndex8Atr7";
            names["highIndex9Atr7"] = "highIndex9Atr7";
            names["highIndex10Atr7"] = "highIndex10Atr7";

            names["highIndex1Atr8"] = "highIndex1Atr8";
            names["highIndex2Atr8"] = "highIndex2Atr8";
            names["highIndex3Atr8"] = "highIndex3Atr8";
            names["highIndex4Atr8"] = "highIndex4Atr8";
            names["highIndex5Atr8"] = "highIndex5Atr8";
            names["highIndex6Atr8"] = "highIndex6Atr8";
            names["highIndex7Atr8"] = "highIndex7Atr8";
            names["highIndex8Atr8"] = "highIndex8Atr8";
            names["highIndex9Atr8"] = "highIndex9Atr8";
            names["highIndex10Atr8"] = "highIndex10Atr8";

            names["highIndex1Atr9"] = "highIndex1Atr9";
            names["highIndex2Atr9"] = "highIndex2Atr9";
            names["highIndex3Atr9"] = "highIndex3Atr9";
            names["highIndex4Atr9"] = "highIndex4Atr9";
            names["highIndex5Atr9"] = "highIndex5Atr9";
            names["highIndex6Atr9"] = "highIndex6Atr9";
            names["highIndex7Atr9"] = "highIndex7Atr9";
            names["highIndex8Atr9"] = "highIndex8Atr9";
            names["highIndex9Atr9"] = "highIndex9Atr9";
            names["highIndex10Atr9"] = "highIndex10Atr9";

            names["highIndex1Atr10"] = "highIndex1Atr10";
            names["highIndex2Atr10"] = "highIndex2Atr10";
            names["highIndex3Atr10"] = "highIndex3Atr10";
            names["highIndex4Atr10"] = "highIndex4Atr10";
            names["highIndex5Atr10"] = "highIndex5Atr10";
            names["highIndex6Atr10"] = "highIndex6Atr10";
            names["highIndex7Atr10"] = "highIndex7Atr10";
            names["highIndex8Atr10"] = "highIndex8Atr10";
            names["highIndex9Atr10"] = "highIndex9Atr10";
            names["highIndex10Atr10"] = "highIndex10Atr10";
        }

        class variableNames : Control{

            Control controlName;
            string name;

            public void newControl(string value)
            {
                this.name = value;
                this.controlName = this.Controls.Find(value, true)[0];
            }

            public Control getControl(string value)
            {
                Control result = this.Controls.Find(value, true)[0];
                return result;
            }
        }

        static void boundCheckAtr1(int indexNum)
        {
 
            for (int i = 1; i < indexNum; i++)
            {
                //if currIndexLOW > currIndexHIGH
                string currLow = String.Format("lowIndex"+ i.ToString() + "Atr1");
                Control currLowCTRL = Form1.FindControl(currLow);
                //if currIndexLOW < prevIndexHIGH

                //if currentIndexHIGH > nextIndexLOW
            }

        }
        static void boundCheckAtr2(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr3(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr4(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr5(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr6(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr7(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr8(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr9(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
        static void boundCheckAtr10(int indexNum)
        {
            //if currIndexLOW > currIndexHIGH

            //if currIndexLOW < prevIndexHIGH

            //if currentIndexHIGH > nextIndexLOW

        }
    }
}


