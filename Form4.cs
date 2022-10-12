//easyNFT nft art builder
//matt beres, september 2022
//lets you input images, set bounds, and then it creates all iterations of your nft
//form4 is the nft viewing page, displays the desired nft
//opened by form3

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace easyNFT
{
    public partial class Form4 : Form
    {
        //holds all bitmaps to print, sent by form3
        public Dictionary<int, Bitmap> bmpDict;

        public Form4(Dictionary<int, Bitmap> sentDict)
        {
            bmpDict = sentDict;
            InitializeComponent();
            this.Refresh();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            //print all bitmaps in the dictionary to form4
            foreach (var curBmp in bmpDict)
            {
                Bitmap printCur = curBmp.Value;
                graph.DrawImage(printCur, new Point(0, 0));
            }
        }
    }
}
