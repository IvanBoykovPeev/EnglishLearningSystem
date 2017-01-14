using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Levels
    {
        public Levels()
        {
            Word = new List<Word>();
        }
        public int LevelsId { get; set; }
        public string Level { get; set; }
        public virtual List<Word> Word { get; set; }
    }
}
