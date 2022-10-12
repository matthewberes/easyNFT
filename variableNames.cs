using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace easyNFT
{
    //connects the name string to its corresponding control
    public class variableNames : Control
    {
        Control controlName;
        string name;
        public variableNames(Form curForm, string value)
        {
            this.name = value;
            this.controlName = curForm.Controls.Find(this.name, true)[0];
        }

        public Control getControl()
        {
            return this.controlName;
        }
    }
}
