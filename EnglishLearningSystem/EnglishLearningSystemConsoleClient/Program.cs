using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishLearningSystemConsoleClient
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg-BG");
            using (var context = new EnglishLearningSystemContext())
            {
                //context.Database.CreateIfNotExists();
                //context.Database.Delete();
                //foreach (var item in context.Words)
                //{
                //    MessageBox.Show(item.WordInBulgarian);
                //}
            }
            //Levels lev = new Levels
            //{
            //    Level = "Level2"
            //};



            using (var context = new EnglishLearningSystemContext())
            {
                Word word = new Word
                {
                    WordInEnglish = "bag",
                    WordInBulgarian = "чанта",
                    LevelsId = 2
                };
                context.Words.Add(word);
                //context.Levels.Add(lev);
                context.SaveChanges();
            }
        }
    }
}
