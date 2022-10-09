using System;
using System.Collections.Generic;
using System.Text;

namespace easyNFT
{
    public class nftObject : Random
    {
        public double[] attributes { get; set; }

        public nftObject(int atrNum)
        {
            attributes = new double[(int)atrNum];
            for (int i = 0; i < atrNum; i++)
            {
                attributes[i] = NextDouble();
            }
        }
    }
}
