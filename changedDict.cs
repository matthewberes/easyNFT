using System;
using System.Collections.Generic;
using System.Text;

namespace easyNFT
{
    public class changedDict
    {
        public Dictionary<string, decimal> curDict;

        
        public changedDict(brs json)
        {
            Dictionary<string, decimal> names = new Dictionary<string, decimal>();

            //lows
            names["lowIndex1Atr1"] = json.lowIndex1Atr1;
            names["lowIndex2Atr1"] = json.lowIndex2Atr1;
            names["lowIndex3Atr1"] = json.lowIndex3Atr1;
            names["lowIndex4Atr1"] = json.lowIndex4Atr1;
            names["lowIndex5Atr1"] = json.lowIndex5Atr1;
            names["lowIndex6Atr1"] = json.lowIndex6Atr1;
            names["lowIndex7Atr1"] = json.lowIndex7Atr1;
            names["lowIndex8Atr1"] = json.lowIndex8Atr1;
            names["lowIndex9Atr1"] = json.lowIndex9Atr1;
            names["lowIndex10Atr1"] = json.lowIndex10Atr1;

            names["lowIndex1Atr2"] = json.lowIndex1Atr2;
            names["lowIndex2Atr2"] = json.lowIndex2Atr2;
            names["lowIndex3Atr2"] = json.lowIndex3Atr2;
            names["lowIndex4Atr2"] = json.lowIndex4Atr2;
            names["lowIndex5Atr2"] = json.lowIndex5Atr2;
            names["lowIndex6Atr2"] = json.lowIndex6Atr2;
            names["lowIndex7Atr2"] = json.lowIndex7Atr2;
            names["lowIndex8Atr2"] = json.lowIndex8Atr2;
            names["lowIndex9Atr2"] = json.lowIndex9Atr2;
            names["lowIndex10Atr2"] = json.lowIndex10Atr2;

            names["lowIndex1Atr3"] = json.lowIndex1Atr3;
            names["lowIndex2Atr3"] = json.lowIndex2Atr3;
            names["lowIndex3Atr3"] = json.lowIndex3Atr3;
            names["lowIndex4Atr3"] = json.lowIndex4Atr3;
            names["lowIndex5Atr3"] = json.lowIndex5Atr3;
            names["lowIndex6Atr3"] = json.lowIndex6Atr3;
            names["lowIndex7Atr3"] = json.lowIndex7Atr3;
            names["lowIndex8Atr3"] = json.lowIndex8Atr3;
            names["lowIndex9Atr3"] = json.lowIndex9Atr3;
            names["lowIndex10Atr3"] = json.lowIndex10Atr3;

            names["lowIndex1Atr4"] = json.lowIndex1Atr4;
            names["lowIndex2Atr4"] = json.lowIndex2Atr4;
            names["lowIndex3Atr4"] = json.lowIndex3Atr4;
            names["lowIndex4Atr4"] = json.lowIndex4Atr4;
            names["lowIndex5Atr4"] = json.lowIndex5Atr4;
            names["lowIndex6Atr4"] = json.lowIndex6Atr4;
            names["lowIndex7Atr4"] = json.lowIndex7Atr4;
            names["lowIndex8Atr4"] = json.lowIndex8Atr4;
            names["lowIndex9Atr4"] = json.lowIndex9Atr4;
            names["lowIndex10Atr4"] = json.lowIndex10Atr4;

            names["lowIndex1Atr5"] = json.lowIndex1Atr5;
            names["lowIndex2Atr5"] = json.lowIndex2Atr5;
            names["lowIndex3Atr5"] = json.lowIndex3Atr5;
            names["lowIndex4Atr5"] = json.lowIndex4Atr5;
            names["lowIndex5Atr5"] = json.lowIndex5Atr5;
            names["lowIndex6Atr5"] = json.lowIndex6Atr5;
            names["lowIndex7Atr5"] = json.lowIndex7Atr5;
            names["lowIndex8Atr5"] = json.lowIndex8Atr5;
            names["lowIndex9Atr5"] = json.lowIndex9Atr5;
            names["lowIndex10Atr5"] = json.lowIndex10Atr5;

            names["lowIndex1Atr6"] = json.lowIndex1Atr6;
            names["lowIndex2Atr6"] = json.lowIndex2Atr6;
            names["lowIndex3Atr6"] = json.lowIndex3Atr6;
            names["lowIndex4Atr6"] = json.lowIndex4Atr6;
            names["lowIndex5Atr6"] = json.lowIndex5Atr6;
            names["lowIndex6Atr6"] = json.lowIndex6Atr6;
            names["lowIndex7Atr6"] = json.lowIndex7Atr6;
            names["lowIndex8Atr6"] = json.lowIndex8Atr6;
            names["lowIndex9Atr6"] = json.lowIndex9Atr6;
            names["lowIndex10Atr6"] = json.lowIndex10Atr6;

            names["lowIndex1Atr7"] = json.lowIndex1Atr7;
            names["lowIndex2Atr7"] = json.lowIndex2Atr7;
            names["lowIndex3Atr7"] = json.lowIndex3Atr7;
            names["lowIndex4Atr7"] = json.lowIndex4Atr7;
            names["lowIndex5Atr7"] = json.lowIndex5Atr7;
            names["lowIndex6Atr7"] = json.lowIndex6Atr7;
            names["lowIndex7Atr7"] = json.lowIndex7Atr7;
            names["lowIndex8Atr7"] = json.lowIndex8Atr7;
            names["lowIndex9Atr7"] = json.lowIndex9Atr7;
            names["lowIndex10Atr7"] = json.lowIndex10Atr7;

            names["lowIndex1Atr8"] = json.lowIndex1Atr8;
            names["lowIndex2Atr8"] = json.lowIndex2Atr8;
            names["lowIndex3Atr8"] = json.lowIndex3Atr8;
            names["lowIndex4Atr8"] = json.lowIndex4Atr8;
            names["lowIndex5Atr8"] = json.lowIndex5Atr8;
            names["lowIndex6Atr8"] = json.lowIndex6Atr8;
            names["lowIndex7Atr8"] = json.lowIndex7Atr8;
            names["lowIndex8Atr8"] = json.lowIndex8Atr8;
            names["lowIndex9Atr8"] = json.lowIndex9Atr8;
            names["lowIndex10Atr8"] = json.lowIndex10Atr8;

            names["lowIndex1Atr9"] = json.lowIndex1Atr9;
            names["lowIndex2Atr9"] = json.lowIndex2Atr9;
            names["lowIndex3Atr9"] = json.lowIndex3Atr9;
            names["lowIndex4Atr9"] = json.lowIndex4Atr9;
            names["lowIndex5Atr9"] = json.lowIndex5Atr9;
            names["lowIndex6Atr9"] = json.lowIndex6Atr9;
            names["lowIndex7Atr9"] = json.lowIndex7Atr9;
            names["lowIndex8Atr9"] = json.lowIndex8Atr9;
            names["lowIndex9Atr9"] = json.lowIndex9Atr9;
            names["lowIndex10Atr9"] = json.lowIndex10Atr9;

            names["lowIndex1Atr10"] = json.lowIndex1Atr10;
            names["lowIndex2Atr10"] = json.lowIndex2Atr10;
            names["lowIndex3Atr10"] = json.lowIndex3Atr10;
            names["lowIndex4Atr10"] = json.lowIndex4Atr10;
            names["lowIndex5Atr10"] = json.lowIndex5Atr10;
            names["lowIndex6Atr10"] = json.lowIndex6Atr10;
            names["lowIndex7Atr10"] = json.lowIndex7Atr10;
            names["lowIndex8Atr10"] = json.lowIndex8Atr10;
            names["lowIndex9Atr10"] = json.lowIndex9Atr10;
            names["lowIndex10Atr10"] = json.lowIndex10Atr10;

            //highs
            names["highIndex1Atr1"] = json.highIndex1Atr1;
            names["highIndex2Atr1"] = json.highIndex2Atr1;
            names["highIndex3Atr1"] = json.highIndex3Atr1;
            names["highIndex4Atr1"] = json.highIndex4Atr1;
            names["highIndex5Atr1"] = json.highIndex5Atr1;
            names["highIndex6Atr1"] = json.highIndex6Atr1;
            names["highIndex7Atr1"] = json.highIndex7Atr1;
            names["highIndex8Atr1"] = json.highIndex8Atr1;
            names["highIndex9Atr1"] = json.highIndex9Atr1;
            names["highIndex10Atr1"] = json.highIndex10Atr1;

            names["highIndex1Atr2"] = json.highIndex1Atr2;
            names["highIndex2Atr2"] = json.highIndex2Atr2;
            names["highIndex3Atr2"] = json.highIndex3Atr2;
            names["highIndex4Atr2"] = json.highIndex4Atr2;
            names["highIndex5Atr2"] = json.highIndex5Atr2;
            names["highIndex6Atr2"] = json.highIndex6Atr2;
            names["highIndex7Atr2"] = json.highIndex7Atr2;
            names["highIndex8Atr2"] = json.highIndex8Atr2;
            names["highIndex9Atr2"] = json.highIndex9Atr2;
            names["highIndex10Atr2"] = json.highIndex10Atr2;

            names["highIndex1Atr3"] = json.highIndex1Atr3;
            names["highIndex2Atr3"] = json.highIndex2Atr3;
            names["highIndex3Atr3"] = json.highIndex3Atr3;
            names["highIndex4Atr3"] = json.highIndex4Atr3;
            names["highIndex5Atr3"] = json.highIndex5Atr3;
            names["highIndex6Atr3"] = json.highIndex6Atr3;
            names["highIndex7Atr3"] = json.highIndex7Atr3;
            names["highIndex8Atr3"] = json.highIndex8Atr3;
            names["highIndex9Atr3"] = json.highIndex9Atr3;
            names["highIndex10Atr3"] = json.highIndex10Atr3;

            names["highIndex1Atr4"] = json.highIndex1Atr4;
            names["highIndex2Atr4"] = json.highIndex2Atr4;
            names["highIndex3Atr4"] = json.highIndex3Atr4;
            names["highIndex4Atr4"] = json.highIndex4Atr4;
            names["highIndex5Atr4"] = json.highIndex5Atr4;
            names["highIndex6Atr4"] = json.highIndex6Atr4;
            names["highIndex7Atr4"] = json.highIndex7Atr4;
            names["highIndex8Atr4"] = json.highIndex8Atr4;
            names["highIndex9Atr4"] = json.highIndex9Atr4;
            names["highIndex10Atr4"] = json.highIndex10Atr4;

            names["highIndex1Atr5"] = json.highIndex1Atr5;
            names["highIndex2Atr5"] = json.highIndex2Atr5;
            names["highIndex3Atr5"] = json.highIndex3Atr5;
            names["highIndex4Atr5"] = json.highIndex4Atr5;
            names["highIndex5Atr5"] = json.highIndex5Atr5;
            names["highIndex6Atr5"] = json.highIndex6Atr5;
            names["highIndex7Atr5"] = json.highIndex7Atr5;
            names["highIndex8Atr5"] = json.highIndex8Atr5;
            names["highIndex9Atr5"] = json.highIndex9Atr5;
            names["highIndex10Atr5"] = json.highIndex10Atr5;

            names["highIndex1Atr6"] = json.highIndex1Atr6;
            names["highIndex2Atr6"] = json.highIndex2Atr6;
            names["highIndex3Atr6"] = json.highIndex3Atr6;
            names["highIndex4Atr6"] = json.highIndex4Atr6;
            names["highIndex5Atr6"] = json.highIndex5Atr6;
            names["highIndex6Atr6"] = json.highIndex6Atr6;
            names["highIndex7Atr6"] = json.highIndex7Atr6;
            names["highIndex8Atr6"] = json.highIndex8Atr6;
            names["highIndex9Atr6"] = json.highIndex9Atr6;
            names["highIndex10Atr6"] = json.highIndex10Atr6;

            names["highIndex1Atr7"] = json.highIndex1Atr7;
            names["highIndex2Atr7"] = json.highIndex2Atr7;
            names["highIndex3Atr7"] = json.highIndex3Atr7;
            names["highIndex4Atr7"] = json.highIndex4Atr7;
            names["highIndex5Atr7"] = json.highIndex5Atr7;
            names["highIndex6Atr7"] = json.highIndex6Atr7;
            names["highIndex7Atr7"] = json.highIndex7Atr7;
            names["highIndex8Atr7"] = json.highIndex8Atr7;
            names["highIndex9Atr7"] = json.highIndex9Atr7;
            names["highIndex10Atr7"] = json.highIndex10Atr7;

            names["highIndex1Atr8"] = json.highIndex1Atr8;
            names["highIndex2Atr8"] = json.highIndex2Atr8;
            names["highIndex3Atr8"] = json.highIndex3Atr8;
            names["highIndex4Atr8"] = json.highIndex4Atr8;
            names["highIndex5Atr8"] = json.highIndex5Atr8;
            names["highIndex6Atr8"] = json.highIndex6Atr8;
            names["highIndex7Atr8"] = json.highIndex7Atr8;
            names["highIndex8Atr8"] = json.highIndex8Atr8;
            names["highIndex9Atr8"] = json.highIndex9Atr8;
            names["highIndex10Atr8"] = json.highIndex10Atr8;

            names["highIndex1Atr9"] = json.highIndex1Atr9;
            names["highIndex2Atr9"] = json.highIndex2Atr9;
            names["highIndex3Atr9"] = json.highIndex3Atr9;
            names["highIndex4Atr9"] = json.highIndex4Atr9;
            names["highIndex5Atr9"] = json.highIndex5Atr9;
            names["highIndex6Atr9"] = json.highIndex6Atr9;
            names["highIndex7Atr9"] = json.highIndex7Atr9;
            names["highIndex8Atr9"] = json.highIndex8Atr9;
            names["highIndex9Atr9"] = json.highIndex9Atr9;
            names["highIndex10Atr9"] = json.highIndex10Atr9;

            names["highIndex1Atr10"] = json.highIndex1Atr10;
            names["highIndex2Atr10"] = json.highIndex2Atr10;
            names["highIndex3Atr10"] = json.highIndex3Atr10;
            names["highIndex4Atr10"] = json.highIndex4Atr10;
            names["highIndex5Atr10"] = json.highIndex5Atr10;
            names["highIndex6Atr10"] = json.highIndex6Atr10;
            names["highIndex7Atr10"] = json.highIndex7Atr10;
            names["highIndex8Atr10"] = json.highIndex8Atr10;
            names["highIndex9Atr10"] = json.highIndex9Atr10;
            names["highIndex10Atr10"] = json.highIndex10Atr10;

            curDict = names;
        }
    }
}
