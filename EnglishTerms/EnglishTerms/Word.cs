using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishTerms
{
    public  class Word
    {
        public Guid WordId { get; set; }
        public string WordEng { get; set; }
        public string WordTur { get; set; }
        public string Sentences { get; set; }
        public string Save { get; set; }
        public string Delete { get; set; }
        public Word() {
            Save = "Save";
            Delete = "Delete";
        }
    }
}
