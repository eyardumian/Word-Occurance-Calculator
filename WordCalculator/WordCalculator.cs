using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCalculator
{
    class WordCalculator
    {
         public static WordOccurrences[] CalculateOccurrences(List<string> sList)
        {
            WordOccurrences[] obj = new WordOccurrences[sList.Count];
            for (int i = 0; i <sList.Count; i++)
            {
                obj[i] = new WordOccurrences();
                obj[i].word = sList[i].ToString();
                for (int j = 0; j < sList.Count; j++)
                {
                    String str = sList[j].ToString();
                    if (obj[i].word == str)
                        {
                        obj[i].count++;
                    }
                }
            }
            return obj;
        }      
    }
}
