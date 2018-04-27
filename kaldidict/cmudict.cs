using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kaldidict
{
    public class cmudict
    {
        //dictid, InsertDT, dictword, pronunciation
        public int dictid { get; set; }

        public DateTime InsertDT { get; set; }

        public string dictword { get; set; }

        public string pronunciation { get; set; }
    }
}
