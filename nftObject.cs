using System;
using System.Collections.Generic;
using System.Text;

namespace easyNFT
{
    //holds nft object that was generated when the template from form2 was submitted
    public class nftObject : Random
    {
        public double[] attributes { get; set; }
        public nftObject(int atrNum)
        {
            //gives a random float value for each attribute and saves them all in an array
            attributes = new double[(int)atrNum];
            for (int i = 0; i < atrNum; i++)
            {
                attributes[i] = NextDouble();
            }
        }
    }
}
