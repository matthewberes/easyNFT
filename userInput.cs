using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace easyNFT
{
    //calculates which attribute has the highest quantity, will affect form2 window width
    public class userInput : Control
    {
        public decimal highestQty;
        public int totalAtr;
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
            decimal curHighest = 0;
            //get number of attributes
            Control atrQty = form.Controls.Find("atrNum", true)[0];
            //for each attribute
            for (int i = 1; i <= ((ComboBox)atrQty).SelectedIndex + 1; i++)
            {
                //get quantity
                Control tempCtrl = form.Controls.Find("qtyAtr" + i, true)[0];
                //if current quantity is the highest so far, save current as highest 
                if (((NumericUpDown)tempCtrl).Value > curHighest)
                {
                    curHighest = ((NumericUpDown)tempCtrl).Value;
                }
            }
            return curHighest;
        }
    }
}
