using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Dictionary
{
    [Serializable]
    public class Word
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public Word(string word, string translate)
        {
            Word1 = word;
            Word2 = translate;
        }
    }
}
