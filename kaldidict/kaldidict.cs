using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kaldidict
{
    public class kaldidict
    {
        //dictid, InsertDT, dictword, lexicon, lexiconp, lexiconp_silprob
        public int dictid { get; set; }

        public DateTime InsertDT { get; set; }

        public string dictword { get; set; }

        public string lexicon { get; set; }

        public string lexiconp { get; set; }

        public string lexiconp_silprob { get; set; }
    }
}
