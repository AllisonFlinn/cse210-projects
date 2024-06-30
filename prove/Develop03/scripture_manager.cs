using System;

namespace scriptureManager
{
    class ScriptureManager
    {
        private Dictionary<string, string> _scriptures = new Dictionary<string, string>();

        public ScriptureManager()
        {
            string[] lines = System.IO.File.ReadAllLines("lds-scriptures.txt");

            foreach (var verse in lines)
            {
                string[] parts = verse.Split("     ");
                _scriptures.Add(parts[0].ToLower(), parts[1]);
            }
        }

        /***********************************************************************
        * PRINT SCRIPTURES
        *
        * Description
        ***********************************************************************/
        public void printScriptures()
        {
            
            foreach(var item in _scriptures)
            {
                Console.WriteLine("Verse "+ item.Key +"->"+ item.Value);
            }
        }
        public string getVerse(string book, int chapter, int verse)
        {
            string sentence = $"{book} {chapter}:{verse}";
            if (!_scriptures.ContainsKey(sentence.ToLower()))
            {
                throw new ArgumentException($"The scripture {sentence} does not exist.");
            }
            return _scriptures[sentence.ToLower()];
        }
    }
}