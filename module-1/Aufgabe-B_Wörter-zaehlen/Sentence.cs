using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_B_Wörter_zaehlen
{
    internal class Sentence
    {
        //Fields
        private List<string> _words { get; set; }
        private int _numberOfWords;
        private string _longestWord;
        private int _numberOfVowals;

        //Properties
        public int NumberOfWords
        {
            get { return _numberOfWords; }
            private set { _numberOfWords = value; }
        }

        public string LongestWord
        {
            get { return _longestWord; }
            private set { _longestWord = value; }
        }

        public int NumberOfVowals
        {
            get { return _numberOfVowals; }
            private set { _numberOfVowals = value; } 
        }

        //Konstruktoren
        public Sentence(string sentence)
        {
            _words = sentence.Split(' ').ToList();

            NumberOfWords = _words.Count;

            LongestWord = SetLongestWord(_words);

            NumberOfVowals = CountNumberOfVowals(sentence);
        }

        //Methoden
        private string SetLongestWord(List<string> words)
        {
            string longestWord = string.Empty;
            int temp = 0;

            foreach (string word in words)
            {
                if (word.Length > temp)
                {
                    temp = word.Length;
                    longestWord = word;
                }
            }

            return longestWord;
        }

        private int CountNumberOfVowals(string words)
        {
            int count = 0;

            foreach (char c in words)
            {
                switch (char.ToLower(c))
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
