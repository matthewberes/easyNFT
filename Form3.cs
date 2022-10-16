//easyNFT nft art builder
//matt beres, september 2022
//lets you input images, set bounds, and then it creates all iterations of your nft
//form3 is the viewing page, asks for the nft you would like to see, lets you change the target json, lets you save the current json as a new json file
//opened by form1 or form2, opens form4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace easyNFT
{
    public partial class Form3 : Form
    {
        //if form3 is opened from form2 this path will be the default
        public string curTemplatePath = @"D:\path.json";
        //controls when form3 is opened by form2
        public static controlDict curControls;
        //controls when form3 is opened by form1
        public static changedDict jsonChanged;
        //tells you if the change button was pressed, new path
        public int changedFlag;
        
        public Form3(controlDict curDict, int boolChange)
        {
            InitializeComponent();
            curControls = curDict;
            changedFlag = boolChange;
            //if form3 was opened by form1 set path to null
            if(changedFlag == 1)
            {
                curTemplatePath = "";
                curPath.Text = "";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Json files (*.json)|*.json"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                //write path to textbox
                curPath.Text = dialog.FileName;
                //save new path locally
                curTemplatePath = dialog.FileName;
                //set up for nftView
                var jsonString = File.ReadAllText(curTemplatePath);
                //tell program that path was changed
                changedFlag = 1;
                //create dictionary of values from json
                List<brs> newVal = JsonConvert.DeserializeObject<List<brs>>(jsonString);
                changedDict newDict = new changedDict(newVal[0]);
                //save dictionary locally
                jsonChanged = newDict;                
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //error msg if no path exists
            if(curTemplatePath == "")
            {
                MessageBox.Show("Select a JSON file.", "Empty Field");
                return;
            }
            //read json data into string
            var jsonString = File.ReadAllText(curTemplatePath);
            //turn json back into brs object
            List<brs> brsJson = JsonConvert.DeserializeObject<List<brs>>(jsonString);
            //send brs to calculate the placement of each atribute between their bounds
            nftView(brsJson[0]);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //save path.json from form2 as a new json for safe keeping
            SaveFileDialog saveCur = new SaveFileDialog();
            saveCur.Filter = "Json files (*.json)|*.json";
            saveCur.FilterIndex = 2;
            saveCur.RestoreDirectory = true;
            if (saveCur.ShowDialog() == DialogResult.OK)
            {
                    System.IO.File.Copy(@"D:\path.json", saveCur.FileName, true);
            }
        }

        public void nftView(brs json)
        {
            //dictionary that will be filled with bitmaps and sent to form4
            Dictionary<int, Bitmap> bmpDict = new Dictionary<int, Bitmap>();
            //dictionary that has all the paths needed to create the bitmaps
            Dictionary<int, string[]> pathDict = new Dictionary<int, string[]>();
            pathDict[0] = json.filesAtr1;
            pathDict[1] = json.filesAtr2;
            pathDict[2] = json.filesAtr3;
            pathDict[3] = json.filesAtr4;
            pathDict[4] = json.filesAtr5;
            pathDict[5] = json.filesAtr6;
            pathDict[6] = json.filesAtr7;
            pathDict[7] = json.filesAtr8;
            pathDict[8] = json.filesAtr9;
            pathDict[9] = json.filesAtr10;
            //the nft to view, essentially the json's nftArray index
            Control nftForView = this.Controls.Find("nftSelected", true)[0];
            //error msg, selected nft does not exist, index out of bounds
            if (((NumericUpDown)nftForView).Value >= json.nftArray.Length)
            {
                MessageBox.Show("NFT doesn't exist", "NULL");
                return;
            }
            //if path has been changed
            if (changedFlag == 1)
            {
                //for each attribute the nft has
                for (int i = 0; i <= json.atrNum; i++)
                {
                    //for each of the files tied to attribute
                    for (int j = 0; j <= json.q[i]; j++)
                    {
                        //get name for current bounds
                        string tempLow = "lowIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();
                        string tempHigh = "highIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();
                        //get values for current bounds
                        decimal curIndexLow = jsonChanged.curDict[tempLow];
                        decimal curIndexHigh = jsonChanged.curDict[tempHigh];
                        //if current attribute number is less than then number of attributes the nft has
                        if (i < json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes.Length)
                        {
                            //if the current attributes value lies between the current bounds
                            if (Math.Round(json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i], 2) >= (double)curIndexLow && Math.Round(json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i], 2) <= (double)curIndexHigh)
                            {
                                //debug bounds checking
                                //MessageBox.Show("atr " + (i + 1).ToString() + " falls under index " + (j + 1).ToString(), json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i].ToString());
                                //create bitmap with proper path
                                Bitmap tempPic = new Bitmap(pathDict[i][j]);
                                //add bitmap to dictionary, will be sent to form4
                                bmpDict[i] = tempPic;
                            }
                        }
                    }
                    //if every attribute has been cycled through, open form4
                    if (i == json.atrNum)
                    {
                        Form4 form4 = new Form4(bmpDict);
                        form4.Show();
                    }
                }
            }
            else
            {
                //for each attribute the nft has
                for (int i = 0; i <= json.atrNum; i++)
                {
                    //for each of the files tied to attribute
                    for (int j = 0; j <= json.q[i]; j++)
                    {
                        //get name for current bounds
                        string tempLow = "lowIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();
                        string tempHigh = "highIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();
                        //get values for current bounds
                        Control curIndexLow = curControls.curDict[tempLow];
                        Control curIndexHigh = curControls.curDict[tempHigh];
                        //if current attribute number is less than then number of attributes the nft has
                        if (i < json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes.Length)
                        {
                            //if the current attributes float value lies between the current bounds
                            if (Math.Round(json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i], 2) >= (double)((NumericUpDown)curIndexLow).Value && json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i] <= (double)((NumericUpDown)curIndexHigh).Value)
                            {
                                //debug bounds checking
                                //MessageBox.Show("atr " + (i + 1).ToString() + " falls under index " + (j + 1).ToString(), json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i].ToString());
                                //create bitmap with proper path
                                Bitmap tempPic = new Bitmap(pathDict[i][j]);
                                //add bitmap to dictionary, will be sent to form4
                                bmpDict[i] = tempPic;
                            }
                        }
                    }
                    //if every attribute has been cycled through, open form4
                    if (i == json.atrNum)
                    {
                        Form4 form4 = new Form4(bmpDict);
                        form4.Show();
                    }
                }
            }                     
        }
    }
}

