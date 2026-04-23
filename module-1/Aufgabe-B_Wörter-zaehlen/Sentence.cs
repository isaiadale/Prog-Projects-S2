using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_B_Wörter_zaehlen
{
    internal class Sentence
    {
        //Fields
        private List<string> _words;
        private int _numberOfWords;
        private string _longestWord;
        private int _numberOfVowels;

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

        public int NumberOfVowels
        {
            get { return _numberOfVowels; }
            private set { _numberOfVowels = value; } 
        }

        //Konstruktoren
        public Sentence(string sentence)
        {
            _words = sentence.Split(' ').ToList();

            NumberOfWords = _words.Count;

            LongestWord = FindLongestWord(_words);

            NumberOfVowels = CountNumberOfVowels(sentence);
        }

        //Methoden
        private string FindLongestWord(List<string> words)
        {
            string longestWord = string.Empty;
            int temp = 0;

            foreach (string word in words)
            {
                string result = word.Trim('!', '?', ',', '.');
                if (result.Length > temp)
                {
                    temp = result.Length;
                    longestWord = result;
                }
            }

            return longestWord;
        }

        private int CountNumberOfVowels(string words)
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