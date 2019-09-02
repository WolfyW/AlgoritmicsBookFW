using System.Collections.Generic;
using System.Linq;

namespace AlgoritmicsBookFW.Recurection.Exercise
{
    public class AnagrammRecurection
    {
        public List<string> AnagrammWords { get; private set; }
        private int _size;
        private char[] _word;

        public AnagrammRecurection(string anagram)
        {
            AnagrammWords = new List<string>();
            _word = anagram.ToArray();
            _size = _word.Length;
            DoAnaramm(_size);
        }

        public void DoAnaramm(int size)
        {
            if (size == 1)
            {
                return;
            }
            for (int i = 0; i < size; i++)
            {
                DoAnaramm(size - 1);
                if (size == 2)
                {
                    AddWord();
                }
                Rotate(size);
            }
        }

        private void Rotate(int size)
        {
            int j;
            int position = _size - size;
            char temp = _word[position];
            for (j = position + 1; j  < _size; j++)
            {
                _word[j - 1] = _word[j];
            }
            _word[j - 1] = temp;
        }

        private void AddWord()
        {
            string word = new string(_word);
            if (AnagrammWords.Contains(word))
                return;

            AnagrammWords.Add(word);
        }
    }
}
