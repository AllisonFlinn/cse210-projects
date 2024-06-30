using System;
using scriptureManager;

namespace reference
{
    class Reference
    {
       private string _book;
       private int _chapter;
       private int _verse;
       private int _endVerse;

        private ScriptureManager sm = new ScriptureManager();
       

       

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = verse;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        : this(book, chapter, startVerse)
        {
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            string verseText = "";
            for (int i = _verse; i <= _endVerse; i++)
            {
                verseText += sm.getVerse(_book, _chapter, i);
                if (i != _endVerse)
                {
                    verseText += " ";
                }
            }
            return verseText;
        }
    }
}