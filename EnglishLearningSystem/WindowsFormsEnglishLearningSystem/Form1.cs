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
        private List<string> level = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new EnglishLearningSystemDataBase())
            {                
                level = context.Levels
                    .Select(s => s.Level)
                    .ToList();
            }
            comboBox1.DataSource = level;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.ResetText();
            label1.ResetText();
            label2.ResetText();
            label3.ResetText();

            string levelSearch = comboBox1.Text;
            if (wordCount >= wordEn.Count)
            {
                wordCount = 0;                
            }

            using (var context = new EnglishLearningSystemDataBase())
            {
                int levelSup = context.Levels
                    .Where(p => p.Level == levelSearch)
                    .Select(p => p.LevelsId)
                    .FirstOrDefault();
                wordEn = context.Words
                    .Where(w => w.LevelsId == levelSup)
                    .Select(w => w.WordInEnglish)
                    .ToList();
                if (wordCount < wordEn.Count)
                {
                textBox1.Text = wordEn[wordCount];
                }
            }

            wordCount++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new EnglishLearningSystemDataBase())
            {
                string serch = textBox1.Text.ToString();
                string wordfind = context.Words
                    .Where(w => w.WordInEnglish == serch)
                    .Select(w => w.WordInBulgarian)
                    .FirstOrDefault();
                if (textBox2.Text == wordfind)
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
                using (var context = new EnglishLearningSystemDataBase())
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
            using (var context = new EnglishLearningSystemDataBase())
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
            string serch = textBox1.Text.ToString();
            using (var context = new EnglishLearningSystemDataBase())
            {
                
                string worddescr = context.Words
                    .Where(w => w.WordInEnglish == serch)
                    .Select(w => w.Description)
                    .FirstOrDefault();
                if (worddescr != null)
                {
                    richTextBox1.Text = worddescr;
                }
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm adForm = new AdminForm();
            adForm.Show();
        }
    }
}
