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
            Form2 test = new Form2();
            test.Show();
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
    }
}


