using System;
using System.Dynamic;
using System.Xml;
using reference;
using word;


namespace scripture
{
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();
    
        

        public Scripture(Reference Reference, string text) 
        {
                _reference = Reference;
                foreach (var txt in text.Split(" "))
                {
                   _words.Add(new Word(txt)); 

                }
        }

        public void HideRandomWords(int numberToHide)
        {
            int count = 0;
            HashSet<int> values = new HashSet<int>(); 
            Random rand = new Random();
            while (count != numberToHide && values.Count != _words.Count)
            {
                int num = rand.Next(_words.Count);
                if (values.Contains(num))
                {
                    continue;
                }
                values.Add(num);
                if (!_words[num].IsHidden())
                {
                    _words[num].Hide();
                    count ++;
                }
            }
            
        }

        public string GetDisplayText()
        {
            string output = _reference.Header();
            foreach(var w in _words)
            {
                output += $" {w.GetDisplayText()}";
            }
            return output;
        }

        public bool IsCompletelyHidden()
        {
            foreach(var w in _words)
            {
                if (!w.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}