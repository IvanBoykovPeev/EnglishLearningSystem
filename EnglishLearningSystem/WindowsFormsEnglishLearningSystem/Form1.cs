using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using Domain;

namespace WindowsFormsEnglishLearningSystem
{
    public partial class Form1 : Form
    {
        private int wordCount = 0;
        private List<string> wordEn = new List<string>();
        private List<string> wordBg = new List<string>();
        private List<int> level = new List<int>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new EnglishLearningSystemContext())
            {                
                level = context.Levels
                    .Select(s => s.LevelsId)
                    .ToList();
            }
            comboBox1.DataSource = level;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (wordCount >= wordEn.Count)
            {
                wordCount = 0;                
            }           
           
            using (var context = new EnglishLearningSystemContext())
            {
                wordEn = context.Words
                    .Where(w => w.LevelsId == (int)comboBox1.SelectedValue)
                    .Select(w => w.WordInEnglish)
                    .ToList();
                textBox1.Text = wordEn[wordCount];
            }

            wordCount++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentWord = textBox1.Text.ToString();
            using (var context = new EnglishLearningSystemContext())
            {
                string serch = textBox1.Text.ToString();
                var wordfind = context.Words
                    .Where(w => w.WordInEnglish == serch)
                    .Select(w => w.WordInBulgarian)
                    .ToList();
                if (textBox2.Text == wordfind[0])
                {
                    label2.Text = "true";
                }
                else
                {
                    label2.Text = "false";
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (var context = new EnglishLearningSystemContext())
                {
                        string serch = textBox1.Text.ToString();

                        var wordfind1 = context.Words
                            .Where(w => w.WordInEnglish == serch)
                            .Select(w => w.WordInBulgarian)
                            .ToList();
                    label1.Text = wordfind1[0].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new EnglishLearningSystemContext())
            {
                string serch = textBox1.Text.ToString();
                var wordsyn = context.Words
                    .Where(w => w.WordInEnglish == serch)
                    .Select(w => w.Synonym)
                    .ToList();
                if (wordsyn[0] != null)
                {
                label3.Text = wordsyn[0].ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new EnglishLearningSystemContext())
            {
                string serch = textBox1.Text.ToString();
                var worddescr = context.Words
                    .Where(w => w.WordInEnglish == serch)
                    .Select(w => w.Description)
                    .ToList();
                if (worddescr[0] != null)
                {
                    richTextBox1.Text = worddescr[0].ToString();
                }
            }
        }
    }
}
