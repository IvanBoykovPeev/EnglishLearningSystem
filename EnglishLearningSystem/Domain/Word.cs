using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Word
    {
        public int Id { get; set; }
        public string WordInEnglish { get; set; }
        public string WordInBulgarian { get; set; }
        public string Description { get; set; }
        public string Synonym { get; set; }
        public int LevelsId { get; set; }
    }
}
