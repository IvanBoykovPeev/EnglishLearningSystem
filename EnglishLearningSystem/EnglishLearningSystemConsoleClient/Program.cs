using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishLearningSystemConsoleClient
{
    class Program
    {

        static void Main()
        {
            using (var context = new EnglishLearningSystemDataBase())
            {
                //context.Database.CreateIfNotExists();
                //context.Database.Delete();
            }
            //Levels lev = new Levels
            //{
            //    Level = "Level1"
            //};



            using (var context = new EnglishLearningSystemDataBase())
            {
                //Get id for word on levels
                List<string> id = new List<string>();
                    id = context.Levels
                    //.Where(p => p.Level == "Level1")
                    .Select(p => p.Level)
                    .ToList();
                foreach (var item in id)
                {
                    Console.WriteLine(item);
                }
                //Console.WriteLine(id);





                //Word word = new Word
                //{
                //    WordInEnglish = "box",
                //    WordInBulgarian = "кутия",
                //    LevelsId = id
                //};
                //context.Levels.Add(lev);
                //context.Words.Add(word);
                //context.SaveChanges();

                //string level = context.Levels
                //        .Where(l => l.LevelsId == 1)
                //        .Select(s => s.Level)
                //        .First();
                //Console.WriteLine(level.ToString());
                //foreach (var item in level)
                //{
                //    Console.WriteLine(item);
                //}
            }
        }
    }
}
