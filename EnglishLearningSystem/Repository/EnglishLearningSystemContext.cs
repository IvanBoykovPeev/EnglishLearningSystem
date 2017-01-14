using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EnglishLearningSystemContext : DbContext
    {
       public DbSet<Word> Words { get; set; }
       public DbSet<Levels> Levels { get; set; }
    }
}
