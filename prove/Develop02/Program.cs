using System;
using System.Formats.Asn1;
using entry;
using journal;
using promptGenerator;






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