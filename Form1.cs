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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(420, 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput curSesh = new userInput();

            Control n1 = this.Controls.Find("inputNameAtr1", true).Single();
            Control n2 = this.Controls.Find("inputNameAtr2", true).Single();
            Control n3 = this.Controls.Find("inputNameAtr3", true).Single();
            Control n4 = this.Controls.Find("inputNameAtr4", true).Single();
            Control n5 = this.Controls.Find("inputNameAtr5", true).Single();
            Control n6 = this.Controls.Find("inputNameAtr6", true).Single();
            Control n7 = this.Controls.Find("inputNameAtr7", true).Single();
            Control n8 = this.Controls.Find("inputNameAtr8", true).Single();
            Control n9 = this.Controls.Find("inputNameAtr9", true).Single();
            Control n10 = this.Controls.Find("inputNameAtr10", true).Single();

            Control q1 = this.Controls.Find("qtyAtr1", true).Single();
            Control q2 = this.Controls.Find("qtyAtr2", true).Single();
            Control q3 = this.Controls.Find("qtyAtr3", true).Single();
            Control q4 = this.Controls.Find("qtyAtr4", true).Single();
            Control q5 = this.Controls.Find("qtyAtr5", true).Single();
            Control q6 = this.Controls.Find("qtyAtr6", true).Single();
            Control q7 = this.Controls.Find("qtyAtr7", true).Single();
            Control q8 = this.Controls.Find("qtyAtr8", true).Single();
            Control q9 = this.Controls.Find("qtyAtr9", true).Single();
            Control q10 = this.Controls.Find("qtyAtr10", true).Single();
            
            if(n1.Text == "" && n1.Visible == true)
            {
                MessageBox.Show("Atr 1 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n2.Text == "" && n2.Visible == true)
            {
                MessageBox.Show("Atr 2 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n3.Text == "" && n3.Visible == true)
            {
                MessageBox.Show("Atr 3 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n4.Text == "" && n4.Visible == true)
            {
                MessageBox.Show("Atr 4 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n5.Text == "" && n5.Visible == true)
            {
                MessageBox.Show("Atr 5 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n6.Text == "" && n6.Visible == true)
            {
                MessageBox.Show("Atr 6 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n7.Text == "" && n7.Visible == true)
            {
                MessageBox.Show("Atr 7 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n8.Text == "" && n8.Visible == true)
            {
                MessageBox.Show("Atr 8 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n9.Text == "" && n9.Visible == true)
            {
                MessageBox.Show("Atr 9 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n10.Text == "" && n10.Visible == true)
            {
                MessageBox.Show("Atr 10 Name = NULL", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            curSesh.nameAtr1 = n1.Text;
            curSesh.nameAtr2 = n2.Text;
            curSesh.nameAtr3 = n3.Text;
            curSesh.nameAtr4 = n4.Text;
            curSesh.nameAtr5 = n5.Text;
            curSesh.nameAtr6 = n6.Text;
            curSesh.nameAtr7 = n7.Text;
            curSesh.nameAtr8 = n8.Text;
            curSesh.nameAtr9 = n9.Text;
            curSesh.nameAtr10 = n10.Text;

            curSesh.qtyAtr1 = ((NumericUpDown)q1).Value;
            curSesh.qtyAtr2 = ((NumericUpDown)q2).Value;
            curSesh.qtyAtr3 = ((NumericUpDown)q3).Value;
            curSesh.qtyAtr4 = ((NumericUpDown)q4).Value;
            curSesh.qtyAtr5 = ((NumericUpDown)q5).Value;
            curSesh.qtyAtr6 = ((NumericUpDown)q6).Value;
            curSesh.qtyAtr7 = ((NumericUpDown)q7).Value;
            curSesh.qtyAtr8 = ((NumericUpDown)q8).Value;
            curSesh.qtyAtr9 = ((NumericUpDown)q9).Value;
            curSesh.qtyAtr10 = ((NumericUpDown)q10).Value;

            curSesh.highestQty = curSesh.getHighest(this);

            Control atrQty = this.Controls.Find("atrNum", true).Single();
            curSesh.totalAtr = ((ComboBox)atrQty).SelectedIndex + 1;

            Form2 inputValues = new Form2(this);
            inputValues.curSeshF2 = curSesh;

            int x = 0;
            int y = 0;

            switch (curSesh.highestQty)
            {
                case 0:
                    x = 321;
                    break;
                case 1:
                    x = 321;
                    break;
                case 2:
                    x = 442;
                    break;
                case 3:
                    x = 563;
                    break;
                case 4:
                    x = 684;
                    break;
                case 5:
                    x = 805;
                    break;
                case 6:
                    x = 932;
                    break;
                case 7:
                    x = 1053;
                    break;
                case 8:
                    x = 1180;
                    break;
                case 9:
                    x = 1300;
                    break;
                case 10:
                    x = 1470;
                    break;
            }

            switch (curSesh.totalAtr)
            {
                case 0:
                    y = 210;
                    break;
                case 1:
                    y = 210;
                    break;
                case 2:
                    y = 300;
                    break;
                case 3:
                    y = 390;
                    break;
                case 4:
                    y = 475;
                    break;
                case 5:
                    y = 560;
                    break;
                case 6:
                    y = 650;
                    break;
                case 7:
                    y = 740;
                    break;
                case 8:
                    y = 830;
                    break;
                case 9:
                    y = 920;
                    break;
                case 10:
                    y = 1060;
                    break;
            }

            inputValues.Size = new Size(x, y);
            inputValues.Show();
        }

        private void atrNum_SelectedValueChanged(object sender, EventArgs e)
        {
            Dictionary<string, Control> names = new Dictionary<string, Control>();

            names["labelNameAtr1"] = labelNameAtr1;
            names["labelNameAtr2"] = labelNameAtr2;
            names["labelNameAtr3"] = labelNameAtr3;
            names["labelNameAtr4"] = labelNameAtr4;
            names["labelNameAtr5"] = labelNameAtr5;
            names["labelNameAtr6"] = labelNameAtr6;
            names["labelNameAtr7"] = labelNameAtr7;
            names["labelNameAtr8"] = labelNameAtr8;
            names["labelNameAtr9"] = labelNameAtr9;
            names["labelNameAtr10"] = labelNameAtr10;

            names["inputNameAtr1"] = inputNameAtr1;
            names["inputNameAtr2"] = inputNameAtr2;
            names["inputNameAtr3"] = inputNameAtr3;
            names["inputNameAtr4"] = inputNameAtr4;
            names["inputNameAtr5"] = inputNameAtr5;
            names["inputNameAtr6"] = inputNameAtr6;
            names["inputNameAtr7"] = inputNameAtr7;
            names["inputNameAtr8"] = inputNameAtr8;
            names["inputNameAtr9"] = inputNameAtr9;
            names["inputNameAtr10"] = inputNameAtr10;

            names["labelQtyAtr1"] = labelQtyAtr1;
            names["labelQtyAtr2"] = labelQtyAtr2;
            names["labelQtyAtr3"] = labelQtyAtr3;
            names["labelQtyAtr4"] = labelQtyAtr4;
            names["labelQtyAtr5"] = labelQtyAtr5;
            names["labelQtyAtr6"] = labelQtyAtr6;
            names["labelQtyAtr7"] = labelQtyAtr7;
            names["labelQtyAtr8"] = labelQtyAtr8;
            names["labelQtyAtr9"] = labelQtyAtr9;
            names["labelQtyAtr10"] = labelQtyAtr10;

            names["qtyAtr1"] = qtyAtr1;
            names["qtyAtr2"] = qtyAtr2;
            names["qtyAtr3"] = qtyAtr3;
            names["qtyAtr4"] = qtyAtr4;
            names["qtyAtr5"] = qtyAtr5;
            names["qtyAtr6"] = qtyAtr6;
            names["qtyAtr7"] = qtyAtr7;
            names["qtyAtr8"] = qtyAtr8;
            names["qtyAtr9"] = qtyAtr9;
            names["qtyAtr10"] = qtyAtr10;

            button1.Visible = true;

            switch (atrNum.SelectedItem.ToString())
            {
                case "1":
                    this.Size = new Size(420, 235);
                    button1.Location = new Point(155, 135);

                    //visible
                    for(int i = 1; i < 2; i++) {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 2; j < 11; j++) {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "2":
                    this.Size = new Size(420, 270);
                    button1.Location = new Point(155, 170);

                    //visible
                    for (int i = 1; i < 3; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 3; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "3":
                    this.Size = new Size(420, 305);
                    button1.Location = new Point(155, 205);

                    //visible
                    for (int i = 1; i < 4; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 4; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "4":
                    this.Size = new Size(420, 340);
                    button1.Location = new Point(155, 240);

                    //visible
                    for (int i = 1; i < 5; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 5; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "5":
                    this.Size = new Size(420, 375);
                    button1.Location = new Point(155, 275);

                    //visible
                    for (int i = 1; i < 6; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 6; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "6":
                    this.Size = new Size(420, 410);
                    button1.Location = new Point(155, 310);

                    //visible
                    for (int i = 1; i < 7; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 7; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "7":
                    this.Size = new Size(420, 445);
                    button1.Location = new Point(155, 345);

                    //visible
                    for (int i = 1; i < 8; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 8; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "8":
                    this.Size = new Size(420, 480);
                    button1.Location = new Point(155, 380);

                    //visible
                    for (int i = 1; i < 9; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 9; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "9":
                    this.Size = new Size(420, 515);
                    button1.Location = new Point(155, 415);

                    //visible
                    for (int i = 1; i < 10; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    //invisible
                    for (int j = 10; j < 11; j++)
                    {
                        string curNameLabel = "labelNameAtr" + j;
                        string curNameInput = "inputNameAtr" + j;
                        string curQtyLabel = "labelQtyAtr" + j;
                        string curQtyInput = "qtyAtr" + j;

                        names[curNameLabel].Visible = false;
                        names[curNameInput].Visible = false;
                        names[curQtyLabel].Visible = false;
                        names[curQtyInput].Visible = false;
                    }
                    break;
                case "10":
                    this.Size = new Size(420, 545);
                    button1.Location = new Point(155, 445);

                    //visible
                    for (int i = 1; i < 11; i++)
                    {
                        string curNameLabel = "labelNameAtr" + i;
                        string curNameInput = "inputNameAtr" + i;
                        string curQtyLabel = "labelQtyAtr" + i;
                        string curQtyInput = "qtyAtr" + i;

                        names[curNameLabel].Visible = true;
                        names[curNameInput].Visible = true;
                        names[curQtyLabel].Visible = true;
                        names[curQtyInput].Visible = true;
                    }
                    break;

            }
        }

        private void lblViewJson_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(new dictionary(), 1);
            form3.Show();
        }
    }    
}


