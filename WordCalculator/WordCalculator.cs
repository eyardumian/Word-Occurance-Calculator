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
        //internal static WordOccurrences[] CalculateOccurrences(List<string> words)
        //{
        //  throw new NotImplementedException();
        //}


         public static void CalculateOccurrences(List<string> sList)
        {
            WordOccurrences[] obj = new WordOccurrences[sList.Count];
            for (int i = 0; i <sList.Count; i++)
            {
                obj[i] = new WordOccurrences();
                obj[i].word = sList[i].ToString();
                //MessageBox.Show(str);
                for (int j = 1; j < sList.Count; j++)
                {
                    String str = sList[j].ToString();
                    if (obj[i].word == str)
                        {
                        obj[i].count++;
                    }
                }
                //return obj;
            }
            //throw new NotImplementedException();
            //Hashtable table = new Hashtable();

        }

        
    }
}
