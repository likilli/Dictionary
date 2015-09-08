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

    public class DictLibrary
    {

        public List<Word> Words { get; private set; }


        public DictLibrary()
        {
            Words = new List<Word>();

        }

        /// <summary>
        /// Find word
        /// </summary>
        /// <param name="newWord">Some word</param>
        /// <returns>Found word</returns>
        public Word Find(string newWord)//Посик слова
        {
            foreach (var w in Words)
            {
                if (newWord == w.Word1 || newWord == w.Word2)
                {
                    return w;
                }

            }
            return null;

        }
        public Word Find(int index)//Посик слова
        {
           
            return Words[index];

        }
        public void AddWord(string newWord, string translate)// Добавляем слово
        {
            if (newWord != string.Empty && translate != string.Empty)
            {

                if (Find(newWord) == null || Find(translate) == null)
                {
                    Word w = new Word(newWord, translate);
                    Words.Add(w);
                }
                else
                {
                    throw new ArgumentException("ERROR1! word is at Dictionary");
                }
            }
            else
            {
                throw new ArgumentException("Error2!");
            }

        }
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = new FileStream("Save.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, Words);
            }
        }
        public void Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = new FileStream("Save.dat", FileMode.Open))
            {
                Words = formatter.Deserialize(fStream) as List<Word>;
            }
        }


        public void DelWord(string dw)// Удаляем слово
        {
            Word found = Find(dw);
            if (found != null)
            {
                Words.Remove(found);
            }
            else
            {
                throw new Exception("Word not found!");
            }
        }
        public string FindTranslationOfWord(string word)
        {
            foreach (var wd in Words)
            {

                if (word == wd.Word1)
                {
                    return wd.Word2;
                }
                else
                {
                    return wd.Word1;  
                }

            }
            throw new Exception("Word not found!");

        }

        //public void LearnWords()
        //{
        //    int r;
        //    int count = 0;
        //    string rw = string.Empty;
        //    while (count != Words.Count)
        //    {
        //        r = rand.Next(0, Words.Count);
        //        if (rw == Words[r].Word1)
        //        {
        //            Console.WriteLine(Words[r].Word1);
        //            rw = Words[r].Word1;

        //            if (Console.ReadLine() == Words[r].Word2)
        //            {
        //                count++;
        //                Console.WriteLine("True");
        //            }
        //            else
        //            {
        //                count = 0;
        //                Console.WriteLine("Wrong answer");
        //                Console.WriteLine(Words[r].Word2);
        //            }
        //        }

        //    }

        //}




    }
}
