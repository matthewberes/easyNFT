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

            //button placement
            Point atr1 = new Point(118, 166);
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
        private void Form2_Load(object sender, EventArgs e)
        {
            buttonPlacement();
            setHeaders(this);

        }
        public void buttonPlacement()
        {
            Control submitButton = this.Controls.Find("submitButton", true).Single();
            switch (this.curSeshF2.totalAtr)
            {
                case 1:
                    submitButton.Location = new Point(118, 130);
                    break;
                case 2:
                    submitButton.Location = new Point(118, 220);
                    break;
                case 3:
                    submitButton.Location = new Point(118, 310);
                    break;
                case 4:
                    submitButton.Location = new Point(118, 395);
                    break;
                case 5:
                    submitButton.Location = new Point(118, 480);
                    break;
                case 6:
                    submitButton.Location = new Point(118, 570);
                    break;
                case 7:
                    submitButton.Location = new Point(118, 660);
                    break;
                case 8:
                    submitButton.Location = new Point(118, 750);
                    break;
                case 9:
                    submitButton.Location = new Point(118, 840);
                    break;
                case 10:
                    submitButton.Location = new Point(118, 936);
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
            Control maxFile1 = this.mainForm.Controls.Find("qtyAtr1", true).Single();
            Control maxFile2 = this.mainForm.Controls.Find("qtyAtr2", true).Single();
            Control maxFile3 = this.mainForm.Controls.Find("qtyAtr3", true).Single();
            Control maxFile4 = this.mainForm.Controls.Find("qtyAtr4", true).Single();
            Control maxFile5 = this.mainForm.Controls.Find("qtyAtr5", true).Single();
            Control maxFile6 = this.mainForm.Controls.Find("qtyAtr6", true).Single();
            Control maxFile7 = this.mainForm.Controls.Find("qtyAtr7", true).Single();
            Control maxFile8 = this.mainForm.Controls.Find("qtyAtr8", true).Single();
            Control maxFile9 = this.mainForm.Controls.Find("qtyAtr9", true).Single();
            Control maxFile10 = this.mainForm.Controls.Find("qtyAtr10", true).Single();

            Dictionary<string, Control> names = new Dictionary<string, Control>();

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

            if (btnAtr1.Visible == true && globalAtr1 < ((NumericUpDown)maxFile1).Value)
            {
                MessageBox.Show("Not enough files for atr1", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr2.Visible == true && globalAtr2 < ((NumericUpDown)maxFile2).Value)
            {
                MessageBox.Show("Not enough files for atr2", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr3.Visible == true && globalAtr3 < ((NumericUpDown)maxFile3).Value)
            {
                MessageBox.Show("Not enough files for atr3", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr4.Visible == true && globalAtr4 < ((NumericUpDown)maxFile4).Value)
            {
                MessageBox.Show("Not enough files for atr4", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr5.Visible == true && globalAtr5 < ((NumericUpDown)maxFile5).Value)
            {
                MessageBox.Show("Not enough files for atr5", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr6.Visible == true && globalAtr6 < ((NumericUpDown)maxFile6).Value)
            {
                MessageBox.Show("Not enough files for atr6", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr7.Visible == true && globalAtr7 < ((NumericUpDown)maxFile7).Value)
            {
                MessageBox.Show("Not enough files for atr7", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr8.Visible == true && globalAtr8 < ((NumericUpDown)maxFile8).Value)
            {
                MessageBox.Show("Not enough files for atr8", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr9.Visible == true && globalAtr9 < ((NumericUpDown)maxFile9).Value)
            {
                MessageBox.Show("Not enough files for atr9", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnAtr10.Visible == true && globalAtr10 < ((NumericUpDown)maxFile10).Value)
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
            //MessageBox.Show("SHIT WORKS CUH", "SUCCESS");
        }
    }
}