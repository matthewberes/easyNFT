using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace easyNFT
{
    public class userInput : Control
    {
        public decimal highestQty;
        public int totalAtr;

        public string nameAtr1;
        public string nameAtr2;
        public string nameAtr3;
        public string nameAtr4;
        public string nameAtr5;
        public string nameAtr6;
        public string nameAtr7;
        public string nameAtr8;
        public string nameAtr9;
        public string nameAtr10;

        public decimal qtyAtr1;
        public decimal qtyAtr2;
        public decimal qtyAtr3;
        public decimal qtyAtr4;
        public decimal qtyAtr5;
        public decimal qtyAtr6;
        public decimal qtyAtr7;
        public decimal qtyAtr8;
        public decimal qtyAtr9;
        public decimal qtyAtr10;

        public userInput() { }

        public decimal getHighest(Form1 form)
        {
            Control atrQty = form.Controls.Find("atrNum", true)[0];

            decimal curHighest = 0;

            for (int i = 1; i <= ((ComboBox)atrQty).SelectedIndex + 1; i++)
            {
                Control tempCtrl = form.Controls.Find("qtyAtr" + i, true)[0];
                if (((NumericUpDown)tempCtrl).Value > curHighest)
                {
                    curHighest = ((NumericUpDown)tempCtrl).Value;
                }
            }

            return curHighest;
        }
    }
}
