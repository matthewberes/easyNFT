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
        
        public Form3()
        {
            InitializeComponent();
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
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //Control curPath = this.Controls.Find("curPath", true)[0];

            var jsonString = File.ReadAllText(curTemplatePath);

            List<brs> brsJson = JsonConvert.DeserializeObject<List<brs>>(jsonString);
            brs curJSON = brsJson[0];
            //INTERPRET TIME
            int i = 0; //debug line
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
    }
}

