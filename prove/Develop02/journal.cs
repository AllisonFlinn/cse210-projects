using System;
using entry;

namespace journal
{
    class Journal
    {
       public List<Entry> _entries = new List<Entry>();
    
       public Journal()
       {
    
       }
    
       public void AddEntry(Entry newEntry)
       {
            _entries.Add(newEntry);
       }
    
       public void DisplayAll()
       {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
       }
    
       public void SaveToFile(string file)
       {
            string header = "date,prompt,entry";
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                outputFile.WriteLine(header);
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
    
            }
       }
    
       public void LoadFromFile(string file)
       {
            string[] lines = System.IO.File.ReadAllLines(file);
            bool firstLine = true;
            foreach (string entryString in lines)
            {
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }
                string[] parts = entryString.Split(",");
                Entry entry = new Entry(parts[0],parts[1],parts[2]);
                AddEntry(entry);
            }
       }
    }
}