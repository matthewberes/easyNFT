using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace easyNFT
{
    //calculates which attribute has the highest quantity, will affect form2 window width
    public class userInput : Control
    {
        public int totalAtr;
        public decimal highestQty;
        public userInput() { }

        public decimal getHighest(Form1 form)
        {
            //return variable for the largest quantity
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
