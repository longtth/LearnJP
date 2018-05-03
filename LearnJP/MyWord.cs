using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnJP
{
    public class MyWord
    {
        public MyWord()
        {
            Kanji = "";
            Furigana = "";
            HanViet = "";
            Meaning = "";
            Sample = "";
        }

        public MyWord(string kanji, string furigana, string hanViet, string meaning, string sample)
        {
            Kanji = kanji;
            Furigana = furigana;
            HanViet = hanViet;
            Meaning = meaning;
            Sample = sample;
        }

        public string Kanji { get; set;  }
        public string Furigana { get; set; }
        public string HanViet { get; set; }
        public string Meaning { get; set; }
        public string Sample { get; set; }

    }
}
