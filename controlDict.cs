using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace easyNFT
{
    //dictionary for controls, used by form3 if no path change has occured
    public class controlDict
    {
        public Dictionary<string, Control> curDict;
        public controlDict()
        {
            curDict = new Dictionary<string, Control>();
        }

        public void addToDict(string key, Control value)
        {
            curDict.Add(key, value);
        }
    }
}
