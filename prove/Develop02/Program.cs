using System;
using System.Formats.Asn1;

class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }


}

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

class PromptGenerator
{
    public List<string> _prompts = ["Who was the most interesting person I interacted with today?",
                                    "What was the best part of my day?",
                                    "How did I see the hand of the Lord in my life today?",
                                    "What was the strongest emotion I felt today?",
                                    "If I had one thing I could do over today, what would it be?"];
    
    static Random rand = new Random();

    public string GetRandomPrompt()
    {
        int numberOfPrompts = _prompts.Count;
        int randomNumber = rand.Next(0,numberOfPrompts);
        return _prompts[randomNumber];
    }
}

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        do
        {
         Console.WriteLine("Please select one of the following choices.");
         Console.WriteLine("1. Write");
         Console.WriteLine("2. Display"); 
         Console.WriteLine("3. Load");
         Console.WriteLine("4. Save"); 
         Console.WriteLine("5. Quit"); 
         Console.Write("What would you like to do? "); 
         userInput = Console.ReadLine(); 
         if (userInput == "1")
         {
            string randomPrompt = prompt.GetRandomPrompt();
            Console.WriteLine(randomPrompt);
            Console.Write("> ");
            string answer = Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Entry entry = new Entry(dateText, randomPrompt, answer);
            journal.AddEntry(entry);
         }
         else if (userInput == "2")
         {
            journal.DisplayAll();

         }
          else if (userInput == "3")
         {
            Console.WriteLine("What is the filename? ");
            string file = Console.ReadLine();
            journal.LoadFromFile(file);
         }
          else if (userInput == "4")
         {
            Console.WriteLine("What is the filename? ");
            string file = Console.ReadLine();
            journal.SaveToFile(file);
         }
          else if (userInput == "5")
         {
            Console.WriteLine("Thank you. Have a nice day.");
         }
         else 
         {
            Console.WriteLine("I'm sorry. That is not a valid answer. Please enter a value between 1 and 5.");
         }
        } while (userInput != "5");
        
    }
}