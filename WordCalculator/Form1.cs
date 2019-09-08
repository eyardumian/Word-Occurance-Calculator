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
            
            WordOccurrences[] obj = WordCalculator.CalculateOccurrences(SplitWords);
            
            String result = "";
            for (int i = 0; i < obj.Length; i++)
            {
                string temp = obj[i].word + ", " + obj[i].count + "\r\n";
                result += temp;
            }
            label1.Text = result;                                       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
