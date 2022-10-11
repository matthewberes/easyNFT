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
            foreach (var curBmp in bmpDict)
            {
                Bitmap printCur = curBmp.Value;
                graph.DrawImage(printCur, new Point(0, 0));
            }
        }
    }
}
