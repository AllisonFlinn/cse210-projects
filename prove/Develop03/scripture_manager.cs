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
                _scriptures.Add(parts[0], parts[1]);
            }
        }

        /***********************************************************************
        * PRINT SCRIPTERS
        *
        * Discription
        ***********************************************************************/
        public void printScriptures()
        {
            
            foreach(var item in _scriptures)
            {
                Console.WriteLine("Verse "+ item.Key +"->"+ item.Value);
            }
        }
    }
}