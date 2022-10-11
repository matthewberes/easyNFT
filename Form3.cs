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
        public string curTemplatePath = @"D:\path.json";
        public static dictionary curControls;
        public static changedDict jsonChanged;
        public int changedFlag;
        
        public Form3(dictionary curDict, int boolChange)
        {
            InitializeComponent();
            curControls = curDict;
            changedFlag = boolChange;
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
                curPath.Text = dialog.FileName;
                curTemplatePath = dialog.FileName;

                //set up for nftView
                var jsonString = File.ReadAllText(curTemplatePath);
                changedFlag = 1;
                List<brs> newVal = JsonConvert.DeserializeObject<List<brs>>(jsonString);
                changedDict newDict = new changedDict(newVal[0]);
                jsonChanged = newDict;
                
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(curTemplatePath == "")
            {
                MessageBox.Show("Select a JSON file.", "Empty Field");
                return;
            }

            var jsonString = File.ReadAllText(curTemplatePath);

            List<brs> brsJson = JsonConvert.DeserializeObject<List<brs>>(jsonString);
            nftView(brsJson[0]);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCur = new SaveFileDialog();
            saveCur.Filter = "Json files (*.json)|*.json";
            saveCur.FilterIndex = 2;
            saveCur.RestoreDirectory = true;
            if (saveCur.ShowDialog() == DialogResult.OK)
            {
                    System.IO.File.Copy(@"D:\path.json", saveCur.FileName, true);
            }
                MessageBox.Show("SHIT WORKS CUH", "SUCCESS");
        }

        public void nftView(brs json)
        {

            Dictionary<int, Bitmap> bmpDict = new Dictionary<int, Bitmap>();

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

            Control nftForView = this.Controls.Find("nftSelected", true)[0];
            //check for error, selected nft does not exist, if (nftSelected > curControls.curDict[nftArray].Length)

            if (changedFlag == 1)
            {
                for (int i = 0; i <= json.atrNum; i++)
                {
                    for (int j = 0; j <= json.q[i]; j++)
                    {
                        //double curAtrVal = json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i];

                        string tempLow = "lowIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();
                        string tempHigh = "highIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();

                        decimal curIndexLow = jsonChanged.curDict[tempLow];
                        decimal curIndexHigh = jsonChanged.curDict[tempHigh];

                        if(((NumericUpDown)nftForView).Value >= json.nftArray.Length)
                        {
                            MessageBox.Show("NFT doesn't exist", "NULL");
                            return;
                        }

                        if (i < json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes.Length)
                        {
                            if (json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i] > (double)curIndexLow && json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i] < (double)curIndexHigh)
                            {
                                //debug bounds checking
                                //MessageBox.Show("atr " + (i + 1).ToString() + " falls under index " + (j + 1).ToString(), json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i].ToString());

                                Bitmap tempPic = new Bitmap(pathDict[i][j]);
                                bmpDict[i] = tempPic;

                            }
                        }
                    }
                    if (i == json.atrNum)
                    {
                        Form4 form4 = new Form4(bmpDict);
                        form4.Show();
                    }
                }
            }
            else
            {
                for (int i = 0; i <= json.atrNum; i++)
                {
                    for (int j = 0; j <= json.q[i]; j++)
                    {
                        string tempLow = "lowIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();
                        string tempHigh = "highIndex" + (j + 1).ToString() + "Atr" + (i + 1).ToString();
                        Control curIndexLow = curControls.curDict[tempLow];
                        Control curIndexHigh = curControls.curDict[tempHigh];

                        if (((NumericUpDown)nftForView).Value >= json.nftArray.Length)
                        {
                            MessageBox.Show("NFT doesn't exist", "NULL");
                            return;
                        }

                        if (i < json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes.Length)
                        {
                            if (json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i] > (double)((NumericUpDown)curIndexLow).Value && json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i] < (double)((NumericUpDown)curIndexHigh).Value)
                            {
                                //debug bounds checking
                                //MessageBox.Show("atr " + (i + 1).ToString() + " falls under index " + (j + 1).ToString(), json.nftArray[(int)((NumericUpDown)nftForView).Value].attributes[i].ToString());

                                Bitmap tempPic = new Bitmap(pathDict[i][j]);
                                bmpDict[i] = tempPic;

                            }
                        }
                    }
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

