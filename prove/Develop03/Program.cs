using System;
using scriptureManager;
using reference;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a scripture you wish to master in the following format: (Book Chapter:verse) or (Book Chapter:verse-end verse)");
        string userInput = Console.ReadLine();
        Reference input = parseUserInput(userInput);
        Console.WriteLine(input.GetDisplayText());
        
    }

    static Reference parseUserInput(string referenceString)
    {   
        bool goodVerse;
        int chapter = 0;
        int verse = 0;

        string[] parts = referenceString.Split(" ");

        string book = parts[0];
        parts = parts[1].Split(":");
        bool goodChapter = Int32.TryParse(parts[0], out chapter);
        if (!goodChapter)
        {
            throw new ArgumentException($"{parts[0]} is not a valid chapter because it is not an integer value.");
        }

        Reference scriptureRef;
        if (parts[1].Contains("-"))
        {
            parts = parts[1].Split("-"); 
            goodVerse = Int32.TryParse(parts[0], out verse);
            if (!goodVerse)
            {
                throw new ArgumentException($"{parts[0]} is not a valid verse because it is not an integer value.");
            }
            int endVerse = 0;
            bool goodEndVerse = Int32.TryParse(parts[1], out endVerse);
            if (!goodEndVerse)
            {
                throw new ArgumentException($"{parts[1]} is not a valid verse because it is not an integer value.");
            }
            scriptureRef = new Reference(book, chapter, verse, endVerse);
            return scriptureRef;
        }

        goodVerse = Int32.TryParse(parts[1], out verse);
        if (!goodVerse)
        {
            throw new ArgumentException($"{parts[1]} is not a valid verse because it is not an integer value.");
        }
        scriptureRef = new Reference(book, chapter, verse);
        return scriptureRef;

        


    }
}