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
using System.Text.Json;
using System.Text.Json.Serialization;

namespace easyNFT
{
    public partial class Form2 : Form
    {
        public Form mainForm;

        public int globalAtr1;
        public int globalAtr2;
        public int globalAtr3;
        public int globalAtr4;
        public int globalAtr5;
        public int globalAtr6;
        public int globalAtr7;
        public int globalAtr8;
        public int globalAtr9;
        public int globalAtr10;
        public userInput curSeshF2 { get; set; }
        public Form2(Form curForm)
        {
            InitializeComponent();
            mainForm = curForm;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            buttonPlacement();
            setHeaders(this);

        }
        public void buttonPlacement()
        {
            Control submitButton = this.Controls.Find("submitButton", true).Single();
            Control submitAmount = this.Controls.Find("submitAmount", true).Single();
            Control submitLbl = this.Controls.Find("submitLbl", true).Single();

            switch (this.curSeshF2.totalAtr)
            {
                case 1:
                    submitButton.Location = new Point(66, 130);
                    submitLbl.Location = new Point(166, 130);
                    submitAmount.Location = new Point(229, 130);
                    break;
                case 2:
                    submitButton.Location = new Point(66, 220);
                    submitLbl.Location = new Point(166, 220);
                    submitAmount.Location = new Point(229, 220);
                    break;
                case 3:
                    submitButton.Location = new Point(66, 310);
                    submitLbl.Location = new Point(166, 310);
                    submitAmount.Location = new Point(229, 310);
                    break;
                case 4:
                    submitButton.Location = new Point(66, 395);
                    submitLbl.Location = new Point(166, 395);
                    submitAmount.Location = new Point(229, 395);
                    break;
                case 5:
                    submitButton.Location = new Point(66, 480);
                    submitLbl.Location = new Point(166, 480);
                    submitAmount.Location = new Point(229, 480);
                    break;
                case 6:
                    submitButton.Location = new Point(66, 570);
                    submitLbl.Location = new Point(166, 570);
                    submitAmount.Location = new Point(229, 570);
                    break;
                case 7:
                    submitButton.Location = new Point(66, 660);
                    submitLbl.Location = new Point(166, 660);
                    submitAmount.Location = new Point(229, 660);
                    break;
                case 8:
                    submitButton.Location = new Point(66, 750);
                    submitLbl.Location = new Point(166, 750);
                    submitAmount.Location = new Point(229, 750);
                    break;
                case 9:
                    submitButton.Location = new Point(66, 840);
                    submitLbl.Location = new Point(166, 840);
                    submitAmount.Location = new Point(229, 840);
                    break;
                case 10:
                    submitButton.Location = new Point(66, 936);
                    submitLbl.Location = new Point(166, 936);
                    submitAmount.Location = new Point(229, 936);
                    break;
            }
        }

        //Changes ttlAtr in form 2 to the corresponding user input in form 1
        public void setHeaders(Form2 curForm)
        {
            Dictionary<string, Control> names = new Dictionary<string, Control>();

            names["q1"] = curForm.mainForm.Controls.Find("qtyAtr1", true).Single();
            names["q2"] = curForm.mainForm.Controls.Find("qtyAtr2", true).Single();
            names["q3"] = curForm.mainForm.Controls.Find("qtyAtr3", true).Single();
            names["q4"] = curForm.mainForm.Controls.Find("qtyAtr4", true).Single();
            names["q5"] = curForm.mainForm.Controls.Find("qtyAtr5", true).Single();
            names["q6"] = curForm.mainForm.Controls.Find("qtyAtr6", true).Single();
            names["q7"] = curForm.mainForm.Controls.Find("qtyAtr7", true).Single();
            names["q8"] = curForm.mainForm.Controls.Find("qtyAtr8", true).Single();
            names["q9"] = curForm.mainForm.Controls.Find("qtyAtr9", true).Single();
            names["q10"] = curForm.mainForm.Controls.Find("qtyAtr10", true).Single();

            for (int i = 1; i <= curForm.curSeshF2.totalAtr; i++)
            {
                string tempF1 = "inputNameAtr" + i.ToString();
                string tempF2 = "ttlAtr" + i.ToString();
                string tempBtn = "btnAtr" + i.ToString();
                Control ctrlF1 = curForm.mainForm.Controls.Find(tempF1, true).Single();
                Control ctrlF2 = curForm.Controls.Find(tempF2, true).Single();
                Control ctrlBtn = curForm.Controls.Find(tempBtn, true).Single();

                //set up titles and upload buttons
                ctrlF2.Text = ctrlF1.Text;
                ctrlF2.Visible = true;
                ctrlBtn.Visible = true;
                //set up indexes
                string temp = "q" + i.ToString();
                setVisible(this, names[temp], i);
            }
        }

        public void setVisible(Form2 curForm, Control indexNum, int curAtr)
        {
            int qty = ((int)((NumericUpDown)indexNum).Value);

            for (int i = 1; i <= qty; i++)
            {
                string tempLow = "lowIndex" + i.ToString() + "Atr" + curAtr.ToString();
                string tempHigh = "highIndex" + i.ToString() + "Atr" + curAtr.ToString();
                string tempLbl = "index" + i.ToString() + "Atr" + curAtr.ToString();
                Control ctrlLow = curForm.Controls.Find(tempLow, true).Single();
                Control ctrlHigh = curForm.Controls.Find(tempHigh, true).Single();
                Control ctrlLbl = curForm.Controls.Find(tempLbl, true).Single();

                ctrlLow.Visible = true;
                ctrlHigh.Visible = true;
                ctrlLbl.Visible = true;
            }
        }

        private void btnAtr1_Click(object sender, EventArgs e)
        {
            Control maxFile = this.mainForm.Controls.Find("qtyAtr1", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr1", "Error: Stack Overflow");
                    return;
                }
                globalAtr1 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr2", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr2", "Error: Stack Overflow");
                    return;
                }
                globalAtr2 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr3", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr3", "Error: Stack Overflow");
                    return;
                }
                globalAtr3 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr4", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr4", "Error: Stack Overflow");
                    return;
                }
                globalAtr4 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr5", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr5", "Error: Stack Overflow");
                    return;
                }
                globalAtr5 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr6", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr6", "Error: Stack Overflow");
                    return;
                }
                globalAtr6 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr7", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr7", "Error: Stack Overflow");
                    return;
                }
                globalAtr7 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr8", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr8", "Error: Stack Overflow");
                    return;
                }
                globalAtr8 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr9", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr9", "Error: Stack Overflow");
                    return;
                }
                globalAtr9 = dialog.FileNames.Length;

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
            Control maxFile = this.mainForm.Controls.Find("qtyAtr10", true).Single();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileNames.Length > ((int)((NumericUpDown)maxFile).Value))
                {
                    MessageBox.Show("Too many files selected for atr10", "Error: Stack Overflow");
                    return;
                }
                globalAtr10 = dialog.FileNames.Length;

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
        public class variableNames : Control {

            Control controlName;
            string name;

            public variableNames(Form curForm, string value)
            {
                this.name = value;
                this.controlName = curForm.Controls.Find(this.name, true).Single();
            }

            public Control getControl()
            {
                //getControl(string value){
                //Control result = this.Controls.Find(value, true)[0];
                //return result;}
                return this.controlName;
            }
        }
        //check for gaps
        static void boundCheckAtr(Form curForm, int atrVal, int indexNum)
        {
            Dictionary<string, int> names = new Dictionary<string, int>();

            for (int i = 1; i <= indexNum; i++)
            {
                //currIndexLOW
                string curLowString = "lowIndex" + i.ToString() + "Atr" + atrVal.ToString();
                variableNames curLowClass = new variableNames(curForm, curLowString);
                Control curLowControl = curLowClass.getControl();
                //currIndexHIGH
                string curHighString = String.Format("highIndex" + i.ToString() + "Atr" + atrVal.ToString());
                variableNames curHighClass = new variableNames(curForm, curHighString);
                Control curHighControl = curHighClass.getControl();

                //nextIndexLOW
                Control nextLowControl = new Control();
                string nextLowString = "";
                if (i < indexNum)
                {
                    nextLowString = String.Format("lowIndex" + (i + 1).ToString() + "Atr" + atrVal.ToString());
                    variableNames nextLowClass = new variableNames(curForm, nextLowString);
                    nextLowControl = nextLowClass.getControl();
                }
                //prevIndexHIGH
                Control prevHighControl = new Control();
                string prevHighString = "";
                if (i > 1)
                {
                    prevHighString = String.Format("highIndex" + (i - 1).ToString() + "Atr" + atrVal.ToString());
                    variableNames prevHighClass = new variableNames(curForm, prevHighString);
                    prevHighControl = prevHighClass.getControl();
                }

                //if currIndexLOW > currIndexHIGH
                if (((NumericUpDown)curLowControl).Value >= ((NumericUpDown)curHighControl).Value)
                {
                    //Error
                    MessageBox.Show(curLowString + " is larger than or equal to " + curHighString, "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //if currIndexLOW < prevIndexHIGH
                if (i > 1)
                {
                    if (((NumericUpDown)curLowControl).Value <= ((NumericUpDown)prevHighControl).Value)
                    {
                        //Error
                        MessageBox.Show(curLowString + " is less than or equal to " + prevHighString, "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //if currentIndexHIGH > nextIndexLOW
                if (i < indexNum)
                {
                    decimal nextLowDec = Convert.ToDecimal(((NumericUpDown)nextLowControl).Value);
                    decimal curHighDec = Convert.ToDecimal(((NumericUpDown)curHighControl).Value);
                    if (curHighDec >= nextLowDec)
                    {
                        //Error
                        MessageBox.Show(nextLowString + " is less than or equal to " + curHighString, "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //check sum initialization
                string tempVal = "val" + i.ToString();
                names[tempVal] = (int)((NumericUpDown)curHighControl).Value - (int)((NumericUpDown)curLowControl).Value;
            }
            //check sum operation
            int sum = 0;
            foreach (KeyValuePair<string, int> entry in names)
            {
                sum += entry.Value;
                if (sum > 1)
                {
                    MessageBox.Show("Atr " + atrVal.ToString() + "'s values summed are greater than 1", "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (sum < 1)
            {
                MessageBox.Show("Atr " + atrVal.ToString() + "'s values summed are less than 1", "Bound Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Control totalAtr = this.mainForm.Controls.Find("atrNum", true).Single();


            Dictionary<string, Control> names = new Dictionary<string, Control>();

            names["n1"] = this.mainForm.Controls.Find("inputNameAtr1", true).Single();
            names["n2"] = this.mainForm.Controls.Find("inputNameAtr2", true).Single();
            names["n3"] = this.mainForm.Controls.Find("inputNameAtr3", true).Single();
            names["n4"] = this.mainForm.Controls.Find("inputNameAtr4", true).Single();
            names["n5"] = this.mainForm.Controls.Find("inputNameAtr5", true).Single();
            names["n6"] = this.mainForm.Controls.Find("inputNameAtr6", true).Single();
            names["n7"] = this.mainForm.Controls.Find("inputNameAtr7", true).Single();
            names["n8"] = this.mainForm.Controls.Find("inputNameAtr8", true).Single();
            names["n9"] = this.mainForm.Controls.Find("inputNameAtr9", true).Single();
            names["n10"] = this.mainForm.Controls.Find("inputNameAtr10", true).Single();

            names["q1"] = this.mainForm.Controls.Find("qtyAtr1", true).Single();
            names["q2"] = this.mainForm.Controls.Find("qtyAtr2", true).Single();
            names["q3"] = this.mainForm.Controls.Find("qtyAtr3", true).Single();
            names["q4"] = this.mainForm.Controls.Find("qtyAtr4", true).Single();
            names["q5"] = this.mainForm.Controls.Find("qtyAtr5", true).Single();
            names["q6"] = this.mainForm.Controls.Find("qtyAtr6", true).Single();
            names["q7"] = this.mainForm.Controls.Find("qtyAtr7", true).Single();
            names["q8"] = this.mainForm.Controls.Find("qtyAtr8", true).Single();
            names["q9"] = this.mainForm.Controls.Find("qtyAtr9", true).Single();
            names["q10"] = this.mainForm.Controls.Find("qtyAtr10", true).Single();

            //lows
            names["lowIndex1Atr1"] = this.Controls.Find("lowIndex1Atr1", true).Single();
            names["lowIndex2Atr1"] = this.Controls.Find("lowIndex2Atr1", true).Single();
            names["lowIndex3Atr1"] = this.Controls.Find("lowIndex3Atr1", true).Single();
            names["lowIndex4Atr1"] = this.Controls.Find("lowIndex4Atr1", true).Single();
            names["lowIndex5Atr1"] = this.Controls.Find("lowIndex5Atr1", true).Single();
            names["lowIndex6Atr1"] = this.Controls.Find("lowIndex6Atr1", true).Single();
            names["lowIndex7Atr1"] = this.Controls.Find("lowIndex7Atr1", true).Single();
            names["lowIndex8Atr1"] = this.Controls.Find("lowIndex8Atr1", true).Single();
            names["lowIndex9Atr1"] = this.Controls.Find("lowIndex9Atr1", true).Single();
            names["lowIndex10Atr1"] = this.Controls.Find("lowIndex10Atr1", true).Single();

            names["lowIndex1Atr2"] = this.Controls.Find("lowIndex1Atr2", true).Single();
            names["lowIndex2Atr2"] = this.Controls.Find("lowIndex2Atr2", true).Single();
            names["lowIndex3Atr2"] = this.Controls.Find("lowIndex3Atr2", true).Single();
            names["lowIndex4Atr2"] = this.Controls.Find("lowIndex4Atr2", true).Single();
            names["lowIndex5Atr2"] = this.Controls.Find("lowIndex5Atr2", true).Single();
            names["lowIndex6Atr2"] = this.Controls.Find("lowIndex6Atr2", true).Single();
            names["lowIndex7Atr2"] = this.Controls.Find("lowIndex7Atr2", true).Single();
            names["lowIndex8Atr2"] = this.Controls.Find("lowIndex8Atr2", true).Single();
            names["lowIndex9Atr2"] = this.Controls.Find("lowIndex9Atr2", true).Single();
            names["lowIndex10Atr2"] = this.Controls.Find("lowIndex10Atr2", true).Single();

            names["lowIndex1Atr3"] = this.Controls.Find("lowIndex1Atr3", true).Single();
            names["lowIndex2Atr3"] = this.Controls.Find("lowIndex2Atr3", true).Single();
            names["lowIndex3Atr3"] = this.Controls.Find("lowIndex3Atr3", true).Single();
            names["lowIndex4Atr3"] = this.Controls.Find("lowIndex4Atr3", true).Single();
            names["lowIndex5Atr3"] = this.Controls.Find("lowIndex5Atr3", true).Single();
            names["lowIndex6Atr3"] = this.Controls.Find("lowIndex6Atr3", true).Single();
            names["lowIndex7Atr3"] = this.Controls.Find("lowIndex7Atr3", true).Single();
            names["lowIndex8Atr3"] = this.Controls.Find("lowIndex8Atr3", true).Single();
            names["lowIndex9Atr3"] = this.Controls.Find("lowIndex9Atr3", true).Single();
            names["lowIndex10Atr3"] = this.Controls.Find("lowIndex10Atr3", true).Single();

            names["lowIndex1Atr4"] = this.Controls.Find("lowIndex1Atr4", true).Single();
            names["lowIndex2Atr4"] = this.Controls.Find("lowIndex2Atr4", true).Single();
            names["lowIndex3Atr4"] = this.Controls.Find("lowIndex3Atr4", true).Single();
            names["lowIndex4Atr4"] = this.Controls.Find("lowIndex4Atr4", true).Single();
            names["lowIndex5Atr4"] = this.Controls.Find("lowIndex5Atr4", true).Single();
            names["lowIndex6Atr4"] = this.Controls.Find("lowIndex6Atr4", true).Single();
            names["lowIndex7Atr4"] = this.Controls.Find("lowIndex7Atr4", true).Single();
            names["lowIndex8Atr4"] = this.Controls.Find("lowIndex8Atr4", true).Single();
            names["lowIndex9Atr4"] = this.Controls.Find("lowIndex9Atr4", true).Single();
            names["lowIndex10Atr4"] = this.Controls.Find("lowIndex10Atr4", true).Single();

            names["lowIndex1Atr5"] = this.Controls.Find("lowIndex1Atr5", true).Single();
            names["lowIndex2Atr5"] = this.Controls.Find("lowIndex2Atr5", true).Single();
            names["lowIndex3Atr5"] = this.Controls.Find("lowIndex3Atr5", true).Single();
            names["lowIndex4Atr5"] = this.Controls.Find("lowIndex4Atr5", true).Single();
            names["lowIndex5Atr5"] = this.Controls.Find("lowIndex5Atr5", true).Single();
            names["lowIndex6Atr5"] = this.Controls.Find("lowIndex6Atr5", true).Single();
            names["lowIndex7Atr5"] = this.Controls.Find("lowIndex7Atr5", true).Single();
            names["lowIndex8Atr5"] = this.Controls.Find("lowIndex8Atr5", true).Single();
            names["lowIndex9Atr5"] = this.Controls.Find("lowIndex9Atr5", true).Single();
            names["lowIndex10Atr5"] = this.Controls.Find("lowIndex10Atr5", true).Single();

            names["lowIndex1Atr6"] = this.Controls.Find("lowIndex1Atr6", true).Single();
            names["lowIndex2Atr6"] = this.Controls.Find("lowIndex2Atr6", true).Single();
            names["lowIndex3Atr6"] = this.Controls.Find("lowIndex3Atr6", true).Single();
            names["lowIndex4Atr6"] = this.Controls.Find("lowIndex4Atr6", true).Single();
            names["lowIndex5Atr6"] = this.Controls.Find("lowIndex5Atr6", true).Single();
            names["lowIndex6Atr6"] = this.Controls.Find("lowIndex6Atr6", true).Single();
            names["lowIndex7Atr6"] = this.Controls.Find("lowIndex7Atr6", true).Single();
            names["lowIndex8Atr6"] = this.Controls.Find("lowIndex8Atr6", true).Single();
            names["lowIndex9Atr6"] = this.Controls.Find("lowIndex9Atr6", true).Single();
            names["lowIndex10Atr6"] = this.Controls.Find("lowIndex10Atr6", true).Single();

            names["lowIndex1Atr7"] = this.Controls.Find("lowIndex1Atr7", true).Single();
            names["lowIndex2Atr7"] = this.Controls.Find("lowIndex2Atr7", true).Single();
            names["lowIndex3Atr7"] = this.Controls.Find("lowIndex3Atr7", true).Single();
            names["lowIndex4Atr7"] = this.Controls.Find("lowIndex4Atr7", true).Single();
            names["lowIndex5Atr7"] = this.Controls.Find("lowIndex5Atr7", true).Single();
            names["lowIndex6Atr7"] = this.Controls.Find("lowIndex6Atr7", true).Single();
            names["lowIndex7Atr7"] = this.Controls.Find("lowIndex7Atr7", true).Single();
            names["lowIndex8Atr7"] = this.Controls.Find("lowIndex8Atr7", true).Single();
            names["lowIndex9Atr7"] = this.Controls.Find("lowIndex9Atr7", true).Single();
            names["lowIndex10Atr7"] = this.Controls.Find("lowIndex10Atr7", true).Single();

            names["lowIndex1Atr8"] = this.Controls.Find("lowIndex1Atr8", true).Single();
            names["lowIndex2Atr8"] = this.Controls.Find("lowIndex2Atr8", true).Single();
            names["lowIndex3Atr8"] = this.Controls.Find("lowIndex3Atr8", true).Single();
            names["lowIndex4Atr8"] = this.Controls.Find("lowIndex4Atr8", true).Single();
            names["lowIndex5Atr8"] = this.Controls.Find("lowIndex5Atr8", true).Single();
            names["lowIndex6Atr8"] = this.Controls.Find("lowIndex6Atr8", true).Single();
            names["lowIndex7Atr8"] = this.Controls.Find("lowIndex7Atr8", true).Single();
            names["lowIndex8Atr8"] = this.Controls.Find("lowIndex8Atr8", true).Single();
            names["lowIndex9Atr8"] = this.Controls.Find("lowIndex9Atr8", true).Single();
            names["lowIndex10Atr8"] = this.Controls.Find("lowIndex10Atr8", true).Single();

            names["lowIndex1Atr9"] = this.Controls.Find("lowIndex1Atr9", true).Single();
            names["lowIndex2Atr9"] = this.Controls.Find("lowIndex2Atr9", true).Single();
            names["lowIndex3Atr9"] = this.Controls.Find("lowIndex3Atr9", true).Single();
            names["lowIndex4Atr9"] = this.Controls.Find("lowIndex4Atr9", true).Single();
            names["lowIndex5Atr9"] = this.Controls.Find("lowIndex5Atr9", true).Single();
            names["lowIndex6Atr9"] = this.Controls.Find("lowIndex6Atr9", true).Single();
            names["lowIndex7Atr9"] = this.Controls.Find("lowIndex7Atr9", true).Single();
            names["lowIndex8Atr9"] = this.Controls.Find("lowIndex8Atr9", true).Single();
            names["lowIndex9Atr9"] = this.Controls.Find("lowIndex9Atr9", true).Single();
            names["lowIndex10Atr9"] = this.Controls.Find("lowIndex10Atr9", true).Single();

            names["lowIndex1Atr10"] = this.Controls.Find("lowIndex1Atr10", true).Single();
            names["lowIndex2Atr10"] = this.Controls.Find("lowIndex2Atr10", true).Single();
            names["lowIndex3Atr10"] = this.Controls.Find("lowIndex3Atr10", true).Single();
            names["lowIndex4Atr10"] = this.Controls.Find("lowIndex4Atr10", true).Single();
            names["lowIndex5Atr10"] = this.Controls.Find("lowIndex5Atr10", true).Single();
            names["lowIndex6Atr10"] = this.Controls.Find("lowIndex6Atr10", true).Single();
            names["lowIndex7Atr10"] = this.Controls.Find("lowIndex7Atr10", true).Single();
            names["lowIndex8Atr10"] = this.Controls.Find("lowIndex8Atr10", true).Single();
            names["lowIndex9Atr10"] = this.Controls.Find("lowIndex9Atr10", true).Single();
            names["lowIndex10Atr10"] = this.Controls.Find("lowIndex10Atr10", true).Single();

            //highs
            names["highIndex1Atr1"] = this.Controls.Find("highIndex1Atr1", true).Single();
            names["highIndex2Atr1"] = this.Controls.Find("highIndex2Atr1", true).Single();
            names["highIndex3Atr1"] = this.Controls.Find("highIndex3Atr1", true).Single();
            names["highIndex4Atr1"] = this.Controls.Find("highIndex4Atr1", true).Single();
            names["highIndex5Atr1"] = this.Controls.Find("highIndex5Atr1", true).Single();
            names["highIndex6Atr1"] = this.Controls.Find("highIndex6Atr1", true).Single();
            names["highIndex7Atr1"] = this.Controls.Find("highIndex7Atr1", true).Single();
            names["highIndex8Atr1"] = this.Controls.Find("highIndex8Atr1", true).Single();
            names["highIndex9Atr1"] = this.Controls.Find("highIndex9Atr1", true).Single();
            names["highIndex10Atr1"] = this.Controls.Find("highIndex10Atr1", true).Single();

            names["highIndex1Atr2"] = this.Controls.Find("highIndex1Atr2", true).Single();
            names["highIndex2Atr2"] = this.Controls.Find("highIndex2Atr2", true).Single();
            names["highIndex3Atr2"] = this.Controls.Find("highIndex3Atr2", true).Single();
            names["highIndex4Atr2"] = this.Controls.Find("highIndex4Atr2", true).Single();
            names["highIndex5Atr2"] = this.Controls.Find("highIndex5Atr2", true).Single();
            names["highIndex6Atr2"] = this.Controls.Find("highIndex6Atr2", true).Single();
            names["highIndex7Atr2"] = this.Controls.Find("highIndex7Atr2", true).Single();
            names["highIndex8Atr2"] = this.Controls.Find("highIndex8Atr2", true).Single();
            names["highIndex9Atr2"] = this.Controls.Find("highIndex9Atr2", true).Single();
            names["highIndex10Atr2"] = this.Controls.Find("highIndex10Atr2", true).Single();

            names["highIndex1Atr3"] = this.Controls.Find("highIndex1Atr3", true).Single();
            names["highIndex2Atr3"] = this.Controls.Find("highIndex2Atr3", true).Single();
            names["highIndex3Atr3"] = this.Controls.Find("highIndex3Atr3", true).Single();
            names["highIndex4Atr3"] = this.Controls.Find("highIndex4Atr3", true).Single();
            names["highIndex5Atr3"] = this.Controls.Find("highIndex5Atr3", true).Single();
            names["highIndex6Atr3"] = this.Controls.Find("highIndex6Atr3", true).Single();
            names["highIndex7Atr3"] = this.Controls.Find("highIndex7Atr3", true).Single();
            names["highIndex8Atr3"] = this.Controls.Find("highIndex8Atr3", true).Single();
            names["highIndex9Atr3"] = this.Controls.Find("highIndex9Atr3", true).Single();
            names["highIndex10Atr3"] = this.Controls.Find("highIndex10Atr3", true).Single();

            names["highIndex1Atr4"] = this.Controls.Find("highIndex1Atr4", true).Single();
            names["highIndex2Atr4"] = this.Controls.Find("highIndex2Atr4", true).Single();
            names["highIndex3Atr4"] = this.Controls.Find("highIndex3Atr4", true).Single();
            names["highIndex4Atr4"] = this.Controls.Find("highIndex4Atr4", true).Single();
            names["highIndex5Atr4"] = this.Controls.Find("highIndex5Atr4", true).Single();
            names["highIndex6Atr4"] = this.Controls.Find("highIndex6Atr4", true).Single();
            names["highIndex7Atr4"] = this.Controls.Find("highIndex7Atr4", true).Single();
            names["highIndex8Atr4"] = this.Controls.Find("highIndex8Atr4", true).Single();
            names["highIndex9Atr4"] = this.Controls.Find("highIndex9Atr4", true).Single();
            names["highIndex10Atr4"] = this.Controls.Find("highIndex10Atr4", true).Single();

            names["highIndex1Atr5"] = this.Controls.Find("highIndex1Atr5", true).Single();
            names["highIndex2Atr5"] = this.Controls.Find("highIndex2Atr5", true).Single();
            names["highIndex3Atr5"] = this.Controls.Find("highIndex3Atr5", true).Single();
            names["highIndex4Atr5"] = this.Controls.Find("highIndex4Atr5", true).Single();
            names["highIndex5Atr5"] = this.Controls.Find("highIndex5Atr5", true).Single();
            names["highIndex6Atr5"] = this.Controls.Find("highIndex6Atr5", true).Single();
            names["highIndex7Atr5"] = this.Controls.Find("highIndex7Atr5", true).Single();
            names["highIndex8Atr5"] = this.Controls.Find("highIndex8Atr5", true).Single();
            names["highIndex9Atr5"] = this.Controls.Find("highIndex9Atr5", true).Single();
            names["highIndex10Atr5"] = this.Controls.Find("highIndex10Atr5", true).Single();

            names["highIndex1Atr6"] = this.Controls.Find("highIndex1Atr6", true).Single();
            names["highIndex2Atr6"] = this.Controls.Find("highIndex2Atr6", true).Single();
            names["highIndex3Atr6"] = this.Controls.Find("highIndex3Atr6", true).Single();
            names["highIndex4Atr6"] = this.Controls.Find("highIndex4Atr6", true).Single();
            names["highIndex5Atr6"] = this.Controls.Find("highIndex5Atr6", true).Single();
            names["highIndex6Atr6"] = this.Controls.Find("highIndex6Atr6", true).Single();
            names["highIndex7Atr6"] = this.Controls.Find("highIndex7Atr6", true).Single();
            names["highIndex8Atr6"] = this.Controls.Find("highIndex8Atr6", true).Single();
            names["highIndex9Atr6"] = this.Controls.Find("highIndex9Atr6", true).Single();
            names["highIndex10Atr6"] = this.Controls.Find("highIndex10Atr6", true).Single();

            names["highIndex1Atr7"] = this.Controls.Find("highIndex1Atr7", true).Single();
            names["highIndex2Atr7"] = this.Controls.Find("highIndex2Atr7", true).Single();
            names["highIndex3Atr7"] = this.Controls.Find("highIndex3Atr7", true).Single();
            names["highIndex4Atr7"] = this.Controls.Find("highIndex4Atr7", true).Single();
            names["highIndex5Atr7"] = this.Controls.Find("highIndex5Atr7", true).Single();
            names["highIndex6Atr7"] = this.Controls.Find("highIndex6Atr7", true).Single();
            names["highIndex7Atr7"] = this.Controls.Find("highIndex7Atr7", true).Single();
            names["highIndex8Atr7"] = this.Controls.Find("highIndex8Atr7", true).Single();
            names["highIndex9Atr7"] = this.Controls.Find("highIndex9Atr7", true).Single();
            names["highIndex10Atr7"] = this.Controls.Find("highIndex10Atr7", true).Single();

            names["highIndex1Atr8"] = this.Controls.Find("highIndex1Atr8", true).Single();
            names["highIndex2Atr8"] = this.Controls.Find("highIndex2Atr8", true).Single();
            names["highIndex3Atr8"] = this.Controls.Find("highIndex3Atr8", true).Single();
            names["highIndex4Atr8"] = this.Controls.Find("highIndex4Atr8", true).Single();
            names["highIndex5Atr8"] = this.Controls.Find("highIndex5Atr8", true).Single();
            names["highIndex6Atr8"] = this.Controls.Find("highIndex6Atr8", true).Single();
            names["highIndex7Atr8"] = this.Controls.Find("highIndex7Atr8", true).Single();
            names["highIndex8Atr8"] = this.Controls.Find("highIndex8Atr8", true).Single();
            names["highIndex9Atr8"] = this.Controls.Find("highIndex9Atr8", true).Single();
            names["highIndex10Atr8"] = this.Controls.Find("highIndex10Atr8", true).Single();

            names["highIndex1Atr9"] = this.Controls.Find("highIndex1Atr9", true).Single();
            names["highIndex2Atr9"] = this.Controls.Find("highIndex2Atr9", true).Single();
            names["highIndex3Atr9"] = this.Controls.Find("highIndex3Atr9", true).Single();
            names["highIndex4Atr9"] = this.Controls.Find("highIndex4Atr9", true).Single();
            names["highIndex5Atr9"] = this.Controls.Find("highIndex5Atr9", true).Single();
            names["highIndex6Atr9"] = this.Controls.Find("highIndex6Atr9", true).Single();
            names["highIndex7Atr9"] = this.Controls.Find("highIndex7Atr9", true).Single();
            names["highIndex8Atr9"] = this.Controls.Find("highIndex8Atr9", true).Single();
            names["highIndex9Atr9"] = this.Controls.Find("highIndex9Atr9", true).Single();
            names["highIndex10Atr9"] = this.Controls.Find("highIndex10Atr9", true).Single();

            names["highIndex1Atr10"] = this.Controls.Find("highIndex1Atr10", true).Single();
            names["highIndex2Atr10"] = this.Controls.Find("highIndex2Atr10", true).Single();
            names["highIndex3Atr10"] = this.Controls.Find("highIndex3Atr10", true).Single();
            names["highIndex4Atr10"] = this.Controls.Find("highIndex4Atr10", true).Single();
            names["highIndex5Atr10"] = this.Controls.Find("highIndex5Atr10", true).Single();
            names["highIndex6Atr10"] = this.Controls.Find("highIndex6Atr10", true).Single();
            names["highIndex7Atr10"] = this.Controls.Find("highIndex7Atr10", true).Single();
            names["highIndex8Atr10"] = this.Controls.Find("highIndex8Atr10", true).Single();
            names["highIndex9Atr10"] = this.Controls.Find("highIndex9Atr10", true).Single();
            names["highIndex10Atr10"] = this.Controls.Find("highIndex10Atr10", true).Single();

            if (btnAtr1.Visible == true && globalAtr1 < ((NumericUpDown)names["q1"]).Value)
            {
                MessageBox.Show("Not enough files for atr1", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr2.Visible == true && globalAtr2 < ((NumericUpDown)names["q2"]).Value)
            {
                MessageBox.Show("Not enough files for atr2", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr3.Visible == true && globalAtr3 < ((NumericUpDown)names["q3"]).Value)
            {
                MessageBox.Show("Not enough files for atr3", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr4.Visible == true && globalAtr4 < ((NumericUpDown)names["q4"]).Value)
            {
                MessageBox.Show("Not enough files for atr4", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr5.Visible == true && globalAtr5 < ((NumericUpDown)names["q5"]).Value)
            {
                MessageBox.Show("Not enough files for atr5", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr6.Visible == true && globalAtr6 < ((NumericUpDown)names["q6"]).Value)
            {
                MessageBox.Show("Not enough files for atr6", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr7.Visible == true && globalAtr7 < ((NumericUpDown)names["q7"]).Value)
            {
                MessageBox.Show("Not enough files for atr7", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr8.Visible == true && globalAtr8 < ((NumericUpDown)names["q8"]).Value)
            {
                MessageBox.Show("Not enough files for atr8", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr9.Visible == true && globalAtr9 < ((NumericUpDown)names["q9"]).Value)
            {
                MessageBox.Show("Not enough files for atr9", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr10.Visible == true && globalAtr10 < ((NumericUpDown)names["q10"]).Value)
            {
                MessageBox.Show("Not enough files for atr10", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 1; i <= ((ComboBox)totalAtr).SelectedIndex + 1; i++)
            {
                string temp = "q" + i.ToString();
                int test = (int)((NumericUpDown)names[temp]).Value;
                boundCheckAtr(this, i, test);
            }

            List<brs> boundReadyState = new List<brs>();
            boundReadyState.Add(new brs() { 
                n1 = ((TextBox)names["n1"]).Text,
                n2 = ((TextBox)names["n2"]).Text,
                n3 = ((TextBox)names["n3"]).Text,
                n4 = ((TextBox)names["n4"]).Text,
                n5 = ((TextBox)names["n5"]).Text,
                n6 = ((TextBox)names["n6"]).Text,
                n7 = ((TextBox)names["n7"]).Text,
                n8 = ((TextBox)names["n8"]).Text,
                n9 = ((TextBox)names["n9"]).Text,
                n10 = ((TextBox)names["n10"]).Text,

                q1 = ((NumericUpDown)names["q1"]).Value,
                q2 = ((NumericUpDown)names["q2"]).Value,
                q3 = ((NumericUpDown)names["q3"]).Value,
                q4 = ((NumericUpDown)names["q4"]).Value,
                q5 = ((NumericUpDown)names["q5"]).Value,
                q6 = ((NumericUpDown)names["q6"]).Value,
                q7 = ((NumericUpDown)names["q7"]).Value,
                q8 = ((NumericUpDown)names["q8"]).Value,
                q9 = ((NumericUpDown)names["q9"]).Value,
                q10 = ((NumericUpDown)names["q10"]).Value,

                //lows
                lowIndex1Atr1 = ((NumericUpDown)names["lowIndex1Atr1"]).Value,
                lowIndex2Atr1 = ((NumericUpDown)names["lowIndex2Atr1"]).Value,
                lowIndex3Atr1 = ((NumericUpDown)names["lowIndex3Atr1"]).Value,
                lowIndex4Atr1 = ((NumericUpDown)names["lowIndex4Atr1"]).Value,
                lowIndex5Atr1 = ((NumericUpDown)names["lowIndex5Atr1"]).Value,
                lowIndex6Atr1 = ((NumericUpDown)names["lowIndex6Atr1"]).Value,
                lowIndex7Atr1 = ((NumericUpDown)names["lowIndex7Atr1"]).Value,
                lowIndex8Atr1 = ((NumericUpDown)names["lowIndex8Atr1"]).Value,
                lowIndex9Atr1 = ((NumericUpDown)names["lowIndex9Atr1"]).Value,
                lowIndex10Atr1 = ((NumericUpDown)names["lowIndex10Atr1"]).Value,

                lowIndex1Atr2 = ((NumericUpDown)names["lowIndex1Atr2"]).Value,
                lowIndex2Atr2 = ((NumericUpDown)names["lowIndex2Atr2"]).Value,
                lowIndex3Atr2 = ((NumericUpDown)names["lowIndex3Atr2"]).Value,
                lowIndex4Atr2 = ((NumericUpDown)names["lowIndex4Atr2"]).Value,
                lowIndex5Atr2 = ((NumericUpDown)names["lowIndex5Atr2"]).Value,
                lowIndex6Atr2 = ((NumericUpDown)names["lowIndex6Atr2"]).Value,
                lowIndex7Atr2 = ((NumericUpDown)names["lowIndex7Atr2"]).Value,
                lowIndex8Atr2 = ((NumericUpDown)names["lowIndex8Atr2"]).Value,
                lowIndex9Atr2 = ((NumericUpDown)names["lowIndex9Atr2"]).Value,
                lowIndex10Atr2 = ((NumericUpDown)names["lowIndex10Atr2"]).Value,

                lowIndex1Atr3 = ((NumericUpDown)names["lowIndex1Atr3"]).Value,
                lowIndex2Atr3 = ((NumericUpDown)names["lowIndex2Atr3"]).Value,
                lowIndex3Atr3 = ((NumericUpDown)names["lowIndex3Atr3"]).Value,
                lowIndex4Atr3 = ((NumericUpDown)names["lowIndex4Atr3"]).Value,
                lowIndex5Atr3 = ((NumericUpDown)names["lowIndex5Atr3"]).Value,
                lowIndex6Atr3 = ((NumericUpDown)names["lowIndex6Atr3"]).Value,
                lowIndex7Atr3 = ((NumericUpDown)names["lowIndex7Atr3"]).Value,
                lowIndex8Atr3 = ((NumericUpDown)names["lowIndex8Atr3"]).Value,
                lowIndex9Atr3 = ((NumericUpDown)names["lowIndex9Atr3"]).Value,
                lowIndex10Atr3 = ((NumericUpDown)names["lowIndex10Atr3"]).Value,

                lowIndex1Atr4 = ((NumericUpDown)names["lowIndex1Atr4"]).Value,
                lowIndex2Atr4 = ((NumericUpDown)names["lowIndex2Atr4"]).Value,
                lowIndex3Atr4 = ((NumericUpDown)names["lowIndex3Atr4"]).Value,
                lowIndex4Atr4 = ((NumericUpDown)names["lowIndex4Atr4"]).Value,
                lowIndex5Atr4 = ((NumericUpDown)names["lowIndex5Atr4"]).Value,
                lowIndex6Atr4 = ((NumericUpDown)names["lowIndex6Atr4"]).Value,
                lowIndex7Atr4 = ((NumericUpDown)names["lowIndex7Atr4"]).Value,
                lowIndex8Atr4 = ((NumericUpDown)names["lowIndex8Atr4"]).Value,
                lowIndex9Atr4 = ((NumericUpDown)names["lowIndex9Atr4"]).Value,
                lowIndex10Atr4 = ((NumericUpDown)names["lowIndex10Atr4"]).Value,

                lowIndex1Atr5 = ((NumericUpDown)names["lowIndex1Atr5"]).Value,
                lowIndex2Atr5 = ((NumericUpDown)names["lowIndex2Atr5"]).Value,
                lowIndex3Atr5 = ((NumericUpDown)names["lowIndex3Atr5"]).Value,
                lowIndex4Atr5 = ((NumericUpDown)names["lowIndex4Atr5"]).Value,
                lowIndex5Atr5 = ((NumericUpDown)names["lowIndex5Atr5"]).Value,
                lowIndex6Atr5 = ((NumericUpDown)names["lowIndex6Atr5"]).Value,
                lowIndex7Atr5 = ((NumericUpDown)names["lowIndex7Atr5"]).Value,
                lowIndex8Atr5 = ((NumericUpDown)names["lowIndex8Atr5"]).Value,
                lowIndex9Atr5 = ((NumericUpDown)names["lowIndex9Atr5"]).Value,
                lowIndex10Atr5 = ((NumericUpDown)names["lowIndex10Atr5"]).Value,

                lowIndex1Atr6 = ((NumericUpDown)names["lowIndex1Atr6"]).Value,
                lowIndex2Atr6 = ((NumericUpDown)names["lowIndex2Atr6"]).Value,
                lowIndex3Atr6 = ((NumericUpDown)names["lowIndex3Atr6"]).Value,
                lowIndex4Atr6 = ((NumericUpDown)names["lowIndex4Atr6"]).Value,
                lowIndex5Atr6 = ((NumericUpDown)names["lowIndex5Atr6"]).Value,
                lowIndex6Atr6 = ((NumericUpDown)names["lowIndex6Atr6"]).Value,
                lowIndex7Atr6 = ((NumericUpDown)names["lowIndex7Atr6"]).Value,
                lowIndex8Atr6 = ((NumericUpDown)names["lowIndex8Atr6"]).Value,
                lowIndex9Atr6 = ((NumericUpDown)names["lowIndex9Atr6"]).Value,
                lowIndex10Atr6 = ((NumericUpDown)names["lowIndex10Atr6"]).Value,

                lowIndex1Atr7 = ((NumericUpDown)names["lowIndex1Atr7"]).Value,
                lowIndex2Atr7 = ((NumericUpDown)names["lowIndex2Atr7"]).Value,
                lowIndex3Atr7 = ((NumericUpDown)names["lowIndex3Atr7"]).Value,
                lowIndex4Atr7 = ((NumericUpDown)names["lowIndex4Atr7"]).Value,
                lowIndex5Atr7 = ((NumericUpDown)names["lowIndex5Atr7"]).Value,
                lowIndex6Atr7 = ((NumericUpDown)names["lowIndex6Atr7"]).Value,
                lowIndex7Atr7 = ((NumericUpDown)names["lowIndex7Atr7"]).Value,
                lowIndex8Atr7 = ((NumericUpDown)names["lowIndex8Atr7"]).Value,
                lowIndex9Atr7 = ((NumericUpDown)names["lowIndex9Atr7"]).Value,
                lowIndex10Atr7 = ((NumericUpDown)names["lowIndex10Atr7"]).Value,

                lowIndex1Atr8 = ((NumericUpDown)names["lowIndex1Atr8"]).Value,
                lowIndex2Atr8 = ((NumericUpDown)names["lowIndex2Atr8"]).Value,
                lowIndex3Atr8 = ((NumericUpDown)names["lowIndex3Atr8"]).Value,
                lowIndex4Atr8 = ((NumericUpDown)names["lowIndex4Atr8"]).Value,
                lowIndex5Atr8 = ((NumericUpDown)names["lowIndex5Atr8"]).Value,
                lowIndex6Atr8 = ((NumericUpDown)names["lowIndex6Atr8"]).Value,
                lowIndex7Atr8 = ((NumericUpDown)names["lowIndex7Atr8"]).Value,
                lowIndex8Atr8 = ((NumericUpDown)names["lowIndex8Atr8"]).Value,
                lowIndex9Atr8 = ((NumericUpDown)names["lowIndex9Atr8"]).Value,
                lowIndex10Atr8 = ((NumericUpDown)names["lowIndex10Atr8"]).Value,

                lowIndex1Atr9 = ((NumericUpDown)names["lowIndex1Atr9"]).Value,
                lowIndex2Atr9 = ((NumericUpDown)names["lowIndex2Atr9"]).Value,
                lowIndex3Atr9 = ((NumericUpDown)names["lowIndex3Atr9"]).Value,
                lowIndex4Atr9 = ((NumericUpDown)names["lowIndex4Atr9"]).Value,
                lowIndex5Atr9 = ((NumericUpDown)names["lowIndex5Atr9"]).Value,
                lowIndex6Atr9 = ((NumericUpDown)names["lowIndex6Atr9"]).Value,
                lowIndex7Atr9 = ((NumericUpDown)names["lowIndex7Atr9"]).Value,
                lowIndex8Atr9 = ((NumericUpDown)names["lowIndex8Atr9"]).Value,
                lowIndex9Atr9 = ((NumericUpDown)names["lowIndex9Atr9"]).Value,
                lowIndex10Atr9 = ((NumericUpDown)names["lowIndex10Atr9"]).Value,

                lowIndex1Atr10 = ((NumericUpDown)names["lowIndex1Atr10"]).Value,
                lowIndex2Atr10 = ((NumericUpDown)names["lowIndex2Atr10"]).Value,
                lowIndex3Atr10 = ((NumericUpDown)names["lowIndex3Atr10"]).Value,
                lowIndex4Atr10 = ((NumericUpDown)names["lowIndex4Atr10"]).Value,
                lowIndex5Atr10 = ((NumericUpDown)names["lowIndex5Atr10"]).Value,
                lowIndex6Atr10 = ((NumericUpDown)names["lowIndex6Atr10"]).Value,
                lowIndex7Atr10 = ((NumericUpDown)names["lowIndex7Atr10"]).Value,
                lowIndex8Atr10 = ((NumericUpDown)names["lowIndex8Atr10"]).Value,
                lowIndex9Atr10 = ((NumericUpDown)names["lowIndex9Atr10"]).Value,
                lowIndex10Atr10 = ((NumericUpDown)names["lowIndex10Atr10"]).Value,

                //highs
                highIndex1Atr1 = ((NumericUpDown)names["highIndex1Atr1"]).Value,
                highIndex2Atr1 = ((NumericUpDown)names["highIndex2Atr1"]).Value,
                highIndex3Atr1 = ((NumericUpDown)names["highIndex3Atr1"]).Value,
                highIndex4Atr1 = ((NumericUpDown)names["highIndex4Atr1"]).Value,
                highIndex5Atr1 = ((NumericUpDown)names["highIndex5Atr1"]).Value,
                highIndex6Atr1 = ((NumericUpDown)names["highIndex6Atr1"]).Value,
                highIndex7Atr1 = ((NumericUpDown)names["highIndex7Atr1"]).Value,
                highIndex8Atr1 = ((NumericUpDown)names["highIndex8Atr1"]).Value,
                highIndex9Atr1 = ((NumericUpDown)names["highIndex9Atr1"]).Value,
                highIndex10Atr1 = ((NumericUpDown)names["highIndex10Atr1"]).Value,

                highIndex1Atr2 = ((NumericUpDown)names["highIndex1Atr2"]).Value,
                highIndex2Atr2 = ((NumericUpDown)names["highIndex2Atr2"]).Value,
                highIndex3Atr2 = ((NumericUpDown)names["highIndex3Atr2"]).Value,
                highIndex4Atr2 = ((NumericUpDown)names["highIndex4Atr2"]).Value,
                highIndex5Atr2 = ((NumericUpDown)names["highIndex5Atr2"]).Value,
                highIndex6Atr2 = ((NumericUpDown)names["highIndex6Atr2"]).Value,
                highIndex7Atr2 = ((NumericUpDown)names["highIndex7Atr2"]).Value,
                highIndex8Atr2 = ((NumericUpDown)names["highIndex8Atr2"]).Value,
                highIndex9Atr2 = ((NumericUpDown)names["highIndex9Atr2"]).Value,
                highIndex10Atr2 = ((NumericUpDown)names["highIndex10Atr2"]).Value,

                highIndex1Atr3 = ((NumericUpDown)names["highIndex1Atr3"]).Value,
                highIndex2Atr3 = ((NumericUpDown)names["highIndex2Atr3"]).Value,
                highIndex3Atr3 = ((NumericUpDown)names["highIndex3Atr3"]).Value,
                highIndex4Atr3 = ((NumericUpDown)names["highIndex4Atr3"]).Value,
                highIndex5Atr3 = ((NumericUpDown)names["highIndex5Atr3"]).Value,
                highIndex6Atr3 = ((NumericUpDown)names["highIndex6Atr3"]).Value,
                highIndex7Atr3 = ((NumericUpDown)names["highIndex7Atr3"]).Value,
                highIndex8Atr3 = ((NumericUpDown)names["highIndex8Atr3"]).Value,
                highIndex9Atr3 = ((NumericUpDown)names["highIndex9Atr3"]).Value,
                highIndex10Atr3 = ((NumericUpDown)names["highIndex10Atr3"]).Value,

                highIndex1Atr4 = ((NumericUpDown)names["highIndex1Atr4"]).Value,
                highIndex2Atr4 = ((NumericUpDown)names["highIndex2Atr4"]).Value,
                highIndex3Atr4 = ((NumericUpDown)names["highIndex3Atr4"]).Value,
                highIndex4Atr4 = ((NumericUpDown)names["highIndex4Atr4"]).Value,
                highIndex5Atr4 = ((NumericUpDown)names["highIndex5Atr4"]).Value,
                highIndex6Atr4 = ((NumericUpDown)names["highIndex6Atr4"]).Value,
                highIndex7Atr4 = ((NumericUpDown)names["highIndex7Atr4"]).Value,
                highIndex8Atr4 = ((NumericUpDown)names["highIndex8Atr4"]).Value,
                highIndex9Atr4 = ((NumericUpDown)names["highIndex9Atr4"]).Value,
                highIndex10Atr4 = ((NumericUpDown)names["highIndex10Atr4"]).Value,

                highIndex1Atr5 = ((NumericUpDown)names["highIndex1Atr5"]).Value,
                highIndex2Atr5 = ((NumericUpDown)names["highIndex2Atr5"]).Value,
                highIndex3Atr5 = ((NumericUpDown)names["highIndex3Atr5"]).Value,
                highIndex4Atr5 = ((NumericUpDown)names["highIndex4Atr5"]).Value,
                highIndex5Atr5 = ((NumericUpDown)names["highIndex5Atr5"]).Value,
                highIndex6Atr5 = ((NumericUpDown)names["highIndex6Atr5"]).Value,
                highIndex7Atr5 = ((NumericUpDown)names["highIndex7Atr5"]).Value,
                highIndex8Atr5 = ((NumericUpDown)names["highIndex8Atr5"]).Value,
                highIndex9Atr5 = ((NumericUpDown)names["highIndex9Atr5"]).Value,
                highIndex10Atr5 = ((NumericUpDown)names["highIndex10Atr5"]).Value,

                highIndex1Atr6 = ((NumericUpDown)names["highIndex1Atr6"]).Value,
                highIndex2Atr6 = ((NumericUpDown)names["highIndex2Atr6"]).Value,
                highIndex3Atr6 = ((NumericUpDown)names["highIndex3Atr6"]).Value,
                highIndex4Atr6 = ((NumericUpDown)names["highIndex4Atr6"]).Value,
                highIndex5Atr6 = ((NumericUpDown)names["highIndex5Atr6"]).Value,
                highIndex6Atr6 = ((NumericUpDown)names["highIndex6Atr6"]).Value,
                highIndex7Atr6 = ((NumericUpDown)names["highIndex7Atr6"]).Value,
                highIndex8Atr6 = ((NumericUpDown)names["highIndex8Atr6"]).Value,
                highIndex9Atr6 = ((NumericUpDown)names["highIndex9Atr6"]).Value,
                highIndex10Atr6 = ((NumericUpDown)names["highIndex10Atr6"]).Value,

                highIndex1Atr7 = ((NumericUpDown)names["highIndex1Atr7"]).Value,
                highIndex2Atr7 = ((NumericUpDown)names["highIndex2Atr7"]).Value,
                highIndex3Atr7 = ((NumericUpDown)names["highIndex3Atr7"]).Value,
                highIndex4Atr7 = ((NumericUpDown)names["highIndex4Atr7"]).Value,
                highIndex5Atr7 = ((NumericUpDown)names["highIndex5Atr7"]).Value,
                highIndex6Atr7 = ((NumericUpDown)names["highIndex6Atr7"]).Value,
                highIndex7Atr7 = ((NumericUpDown)names["highIndex7Atr7"]).Value,
                highIndex8Atr7 = ((NumericUpDown)names["highIndex8Atr7"]).Value,
                highIndex9Atr7 = ((NumericUpDown)names["highIndex9Atr7"]).Value,
                highIndex10Atr7 = ((NumericUpDown)names["highIndex10Atr7"]).Value,

                highIndex1Atr8 = ((NumericUpDown)names["highIndex1Atr8"]).Value,
                highIndex2Atr8 = ((NumericUpDown)names["highIndex2Atr8"]).Value,
                highIndex3Atr8 = ((NumericUpDown)names["highIndex3Atr8"]).Value,
                highIndex4Atr8 = ((NumericUpDown)names["highIndex4Atr8"]).Value,
                highIndex5Atr8 = ((NumericUpDown)names["highIndex5Atr8"]).Value,
                highIndex6Atr8 = ((NumericUpDown)names["highIndex6Atr8"]).Value,
                highIndex7Atr8 = ((NumericUpDown)names["highIndex7Atr8"]).Value,
                highIndex8Atr8 = ((NumericUpDown)names["highIndex8Atr8"]).Value,
                highIndex9Atr8 = ((NumericUpDown)names["highIndex9Atr8"]).Value,
                highIndex10Atr8 = ((NumericUpDown)names["highIndex10Atr8"]).Value,

                highIndex1Atr9 = ((NumericUpDown)names["highIndex1Atr9"]).Value,
                highIndex2Atr9 = ((NumericUpDown)names["highIndex2Atr9"]).Value,
                highIndex3Atr9 = ((NumericUpDown)names["highIndex3Atr9"]).Value,
                highIndex4Atr9 = ((NumericUpDown)names["highIndex4Atr9"]).Value,
                highIndex5Atr9 = ((NumericUpDown)names["highIndex5Atr9"]).Value,
                highIndex6Atr9 = ((NumericUpDown)names["highIndex6Atr9"]).Value,
                highIndex7Atr9 = ((NumericUpDown)names["highIndex7Atr9"]).Value,
                highIndex8Atr9 = ((NumericUpDown)names["highIndex8Atr9"]).Value,
                highIndex9Atr9 = ((NumericUpDown)names["highIndex9Atr9"]).Value,
                highIndex10Atr9 = ((NumericUpDown)names["highIndex10Atr9"]).Value,

                highIndex1Atr10 = ((NumericUpDown)names["highIndex1Atr10"]).Value,
                highIndex2Atr10 = ((NumericUpDown)names["highIndex2Atr10"]).Value,
                highIndex3Atr10 = ((NumericUpDown)names["highIndex3Atr10"]).Value,
                highIndex4Atr10 = ((NumericUpDown)names["highIndex4Atr10"]).Value,
                highIndex5Atr10 = ((NumericUpDown)names["highIndex5Atr10"]).Value,
                highIndex6Atr10 = ((NumericUpDown)names["highIndex6Atr10"]).Value,
                highIndex7Atr10 = ((NumericUpDown)names["highIndex7Atr10"]).Value,
                highIndex8Atr10 = ((NumericUpDown)names["highIndex8Atr10"]).Value,
                highIndex9Atr10 = ((NumericUpDown)names["highIndex9Atr10"]).Value,
                highIndex10Atr10 = ((NumericUpDown)names["highIndex10Atr10"]).Value
            });

            string json = JsonSerializer.Serialize(boundReadyState);

            File.WriteAllText(@"D:\path.json", json);

            MessageBox.Show("SHIT WORKS CUH", "SUCCESS");
        }
    }

    public class brs
    {
        public brs(){ }
            public string n1 { get; set; }
            public string n2 { get; set; }
            public string n3 { get; set; }
            public string n4 { get; set; }
            public string n5 { get; set; }
            public string n6 { get; set; }
            public string n7 { get; set; }
            public string n8 { get; set; }
            public string n9 { get; set; }
            public string n10 { get; set; }

            public decimal q1 { get; set; }
            public decimal q2 { get; set; }
            public decimal q3 { get; set; }
            public decimal q4 { get; set; }
            public decimal q5 { get; set; }
            public decimal q6 { get; set; }
            public decimal q7 { get; set; }
            public decimal q8 { get; set; }
            public decimal q9 { get; set; }
            public decimal q10 { get; set; }

            //lows
            public decimal lowIndex1Atr1 { get; set; }
            public decimal lowIndex2Atr1 { get; set; }
            public decimal lowIndex3Atr1 { get; set; }
            public decimal lowIndex4Atr1 { get; set; }
            public decimal lowIndex5Atr1 { get; set; }
            public decimal lowIndex6Atr1 { get; set; }
            public decimal lowIndex7Atr1 { get; set; }
            public decimal lowIndex8Atr1 { get; set; }
            public decimal lowIndex9Atr1 { get; set; }
            public decimal lowIndex10Atr1 { get; set; }

            public decimal lowIndex1Atr2 { get; set; }
            public decimal lowIndex2Atr2 { get; set; }
            public decimal lowIndex3Atr2 { get; set; }
            public decimal lowIndex4Atr2 { get; set; }
            public decimal lowIndex5Atr2 { get; set; }
            public decimal lowIndex6Atr2 { get; set; }
            public decimal lowIndex7Atr2 { get; set; }
            public decimal lowIndex8Atr2 { get; set; }
            public decimal lowIndex9Atr2 { get; set; }
            public decimal lowIndex10Atr2 { get; set; }

            public decimal lowIndex1Atr3 { get; set; }
            public decimal lowIndex2Atr3 { get; set; }
            public decimal lowIndex3Atr3 { get; set; }
            public decimal lowIndex4Atr3 { get; set; }
            public decimal lowIndex5Atr3 { get; set; }
            public decimal lowIndex6Atr3 { get; set; }
            public decimal lowIndex7Atr3 { get; set; }
            public decimal lowIndex8Atr3 { get; set; }
            public decimal lowIndex9Atr3 { get; set; }
            public decimal lowIndex10Atr3 { get; set; }

            public decimal lowIndex1Atr4 { get; set; }
            public decimal lowIndex2Atr4 { get; set; }
            public decimal lowIndex3Atr4 { get; set; }
            public decimal lowIndex4Atr4 { get; set; }
            public decimal lowIndex5Atr4 { get; set; }
            public decimal lowIndex6Atr4 { get; set; }
            public decimal lowIndex7Atr4 { get; set; }
            public decimal lowIndex8Atr4 { get; set; }
            public decimal lowIndex9Atr4 { get; set; }
            public decimal lowIndex10Atr4 { get; set; }

            public decimal lowIndex1Atr5 { get; set; }
            public decimal lowIndex2Atr5 { get; set; }
            public decimal lowIndex3Atr5 { get; set; }
            public decimal lowIndex4Atr5 { get; set; }
            public decimal lowIndex5Atr5 { get; set; }
            public decimal lowIndex6Atr5 { get; set; }
            public decimal lowIndex7Atr5 { get; set; }
            public decimal lowIndex8Atr5 { get; set; }
            public decimal lowIndex9Atr5 { get; set; }
            public decimal lowIndex10Atr5 { get; set; }

            public decimal lowIndex1Atr6 { get; set; }
            public decimal lowIndex2Atr6 { get; set; }
            public decimal lowIndex3Atr6 { get; set; }
            public decimal lowIndex4Atr6 { get; set; }
            public decimal lowIndex5Atr6 { get; set; }
            public decimal lowIndex6Atr6 { get; set; }
            public decimal lowIndex7Atr6 { get; set; }
            public decimal lowIndex8Atr6 { get; set; }
            public decimal lowIndex9Atr6 { get; set; }
            public decimal lowIndex10Atr6 { get; set; }

            public decimal lowIndex1Atr7 { get; set; }
            public decimal lowIndex2Atr7 { get; set; }
            public decimal lowIndex3Atr7 { get; set; }
            public decimal lowIndex4Atr7 { get; set; }
            public decimal lowIndex5Atr7 { get; set; }
            public decimal lowIndex6Atr7 { get; set; }
            public decimal lowIndex7Atr7 { get; set; }
            public decimal lowIndex8Atr7 { get; set; }
            public decimal lowIndex9Atr7 { get; set; }
            public decimal lowIndex10Atr7 { get; set; }

            public decimal lowIndex1Atr8 { get; set; }
            public decimal lowIndex2Atr8 { get; set; }
            public decimal lowIndex3Atr8 { get; set; }
            public decimal lowIndex4Atr8 { get; set; }
            public decimal lowIndex5Atr8 { get; set; }
            public decimal lowIndex6Atr8 { get; set; }
            public decimal lowIndex7Atr8 { get; set; }
            public decimal lowIndex8Atr8 { get; set; }
            public decimal lowIndex9Atr8 { get; set; }
            public decimal lowIndex10Atr8 { get; set; }

            public decimal lowIndex1Atr9 { get; set; }
            public decimal lowIndex2Atr9 { get; set; }
            public decimal lowIndex3Atr9 { get; set; }
            public decimal lowIndex4Atr9 { get; set; }
            public decimal lowIndex5Atr9 { get; set; }
            public decimal lowIndex6Atr9 { get; set; }
            public decimal lowIndex7Atr9 { get; set; }
            public decimal lowIndex8Atr9 { get; set; }
            public decimal lowIndex9Atr9 { get; set; }
            public decimal lowIndex10Atr9 { get; set; }

            public decimal lowIndex1Atr10 { get; set; }
            public decimal lowIndex2Atr10 { get; set; }
            public decimal lowIndex3Atr10 { get; set; }
            public decimal lowIndex4Atr10 { get; set; }
            public decimal lowIndex5Atr10 { get; set; }
            public decimal lowIndex6Atr10 { get; set; }
            public decimal lowIndex7Atr10 { get; set; }
            public decimal lowIndex8Atr10 { get; set; }
            public decimal lowIndex9Atr10 { get; set; }
            public decimal lowIndex10Atr10 { get; set; }

            //highs               
            public decimal highIndex1Atr1 { get; set; }
            public decimal highIndex2Atr1 { get; set; }
            public decimal highIndex3Atr1 { get; set; }
            public decimal highIndex4Atr1 { get; set; }
            public decimal highIndex5Atr1 { get; set; }
            public decimal highIndex6Atr1 { get; set; }
            public decimal highIndex7Atr1 { get; set; }
            public decimal highIndex8Atr1 { get; set; }
            public decimal highIndex9Atr1 { get; set; }
            public decimal highIndex10Atr1 { get; set; }

            public decimal highIndex1Atr2 { get; set; }
            public decimal highIndex2Atr2 { get; set; }
            public decimal highIndex3Atr2 { get; set; }
            public decimal highIndex4Atr2 { get; set; }
            public decimal highIndex5Atr2 { get; set; }
            public decimal highIndex6Atr2 { get; set; }
            public decimal highIndex7Atr2 { get; set; }
            public decimal highIndex8Atr2 { get; set; }
            public decimal highIndex9Atr2 { get; set; }
            public decimal highIndex10Atr2 { get; set; }

            public decimal highIndex1Atr3 { get; set; }
            public decimal highIndex2Atr3 { get; set; }
            public decimal highIndex3Atr3 { get; set; }
            public decimal highIndex4Atr3 { get; set; }
            public decimal highIndex5Atr3 { get; set; }
            public decimal highIndex6Atr3 { get; set; }
            public decimal highIndex7Atr3 { get; set; }
            public decimal highIndex8Atr3 { get; set; }
            public decimal highIndex9Atr3 { get; set; }
            public decimal highIndex10Atr3 { get; set; }

            public decimal highIndex1Atr4 { get; set; }
            public decimal highIndex2Atr4 { get; set; }
            public decimal highIndex3Atr4 { get; set; }
            public decimal highIndex4Atr4 { get; set; }
            public decimal highIndex5Atr4 { get; set; }
            public decimal highIndex6Atr4 { get; set; }
            public decimal highIndex7Atr4 { get; set; }
            public decimal highIndex8Atr4 { get; set; }
            public decimal highIndex9Atr4 { get; set; }
            public decimal highIndex10Atr4 { get; set; }

            public decimal highIndex1Atr5 { get; set; }
            public decimal highIndex2Atr5 { get; set; }
            public decimal highIndex3Atr5 { get; set; }
            public decimal highIndex4Atr5 { get; set; }
            public decimal highIndex5Atr5 { get; set; }
            public decimal highIndex6Atr5 { get; set; }
            public decimal highIndex7Atr5 { get; set; }
            public decimal highIndex8Atr5 { get; set; }
            public decimal highIndex9Atr5 { get; set; }
            public decimal highIndex10Atr5 { get; set; }

            public decimal highIndex1Atr6 { get; set; }
            public decimal highIndex2Atr6 { get; set; }
            public decimal highIndex3Atr6 { get; set; }
            public decimal highIndex4Atr6 { get; set; }
            public decimal highIndex5Atr6 { get; set; }
            public decimal highIndex6Atr6 { get; set; }
            public decimal highIndex7Atr6 { get; set; }
            public decimal highIndex8Atr6 { get; set; }
            public decimal highIndex9Atr6 { get; set; }
            public decimal highIndex10Atr6 { get; set; }

            public decimal highIndex1Atr7 { get; set; }
            public decimal highIndex2Atr7 { get; set; }
            public decimal highIndex3Atr7 { get; set; }
            public decimal highIndex4Atr7 { get; set; }
            public decimal highIndex5Atr7 { get; set; }
            public decimal highIndex6Atr7 { get; set; }
            public decimal highIndex7Atr7 { get; set; }
            public decimal highIndex8Atr7 { get; set; }
            public decimal highIndex9Atr7 { get; set; }
            public decimal highIndex10Atr7 { get; set; }

            public decimal highIndex1Atr8 { get; set; }
            public decimal highIndex2Atr8 { get; set; }
            public decimal highIndex3Atr8 { get; set; }
            public decimal highIndex4Atr8 { get; set; }
            public decimal highIndex5Atr8 { get; set; }
            public decimal highIndex6Atr8 { get; set; }
            public decimal highIndex7Atr8 { get; set; }
            public decimal highIndex8Atr8 { get; set; }
            public decimal highIndex9Atr8 { get; set; }
            public decimal highIndex10Atr8 { get; set; }

            public decimal highIndex1Atr9 { get; set; }
            public decimal highIndex2Atr9 { get; set; }
            public decimal highIndex3Atr9 { get; set; }
            public decimal highIndex4Atr9 { get; set; }
            public decimal highIndex5Atr9 { get; set; }
            public decimal highIndex6Atr9 { get; set; }
            public decimal highIndex7Atr9 { get; set; }
            public decimal highIndex8Atr9 { get; set; }
            public decimal highIndex9Atr9 { get; set; }
            public decimal highIndex10Atr9 { get; set; }

            public decimal highIndex1Atr10 { get; set; }
            public decimal highIndex2Atr10 { get; set; }
            public decimal highIndex3Atr10 { get; set; }
            public decimal highIndex4Atr10 { get; set; }
            public decimal highIndex5Atr10 { get; set; }
            public decimal highIndex6Atr10 { get; set; }
            public decimal highIndex7Atr10 { get; set; }
            public decimal highIndex8Atr10 { get; set; }
            public decimal highIndex9Atr10 { get; set; }
            public decimal highIndex10Atr10 { get; set; }   
    }
}