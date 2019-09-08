using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCalculator
{
    public partial class Form1 : Form
    {
        private const char Separator = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = textBox1.Text;
            List<string> SplitWords = input.Split(Separator).ToList();
            
            WordCalculator.CalculateOccurrences(SplitWords);

            MessageBox.Show(SplitWords);
            //label1.Text = SplitWords.ToList();
                            

            //List<string> words = new List<string>();
           // for (int i = 0; i < SplitWords.Length; i++)
            //{
                
            //}

            //WordOccurrences[] obj = WordCalculator.CalculateOccurrences(words);

            //for (int i = 0; i < obj.Length; i++)
            //{
              //  String results = obj[i].word + ", " + obj[i].count;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
