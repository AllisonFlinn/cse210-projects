using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        BreathingActivity ba = new BreathingActivity();
        ReflectingActivity ra = new ReflectingActivity();
        ListingActivity la = new ListingActivity();
        List<string> log = new List<string>();
        do 
        {//I think this needs a loop of some sort to keep it going.
            //This displays the menu for the user to select from.
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Write current session log");  //This is my additional credit item
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu:  ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                //This needs to display the name of the activity and description
                //It needs to ask how long in seconds the session should be
                //It then will say "get ready" with a spinner
                //followed by breath in, breath out count downs
                //display well done you have completed time of activity name
                ba.Run();
                log.Add(ba.WriteLog());
            }
            else if (answer == "2")
            {
                //This needs to display the name of the activity and description
                //It needs to ask how long in seconds the session should be
                //It then will say "get ready" with a spinner
                //Consider the following prompt
                //random prompt
                //when ready press enter
                //ponder the following questions with a countdown timer
                //display question and spinner
                //display question and spinner
                //display well done you have completed time of activity name
                ra.Run();
                log.Add(ra.WriteLog());
            }
            else if (answer == "3")
            {
                //This needs to display the name of the activity and description
                //It needs to ask how long in seconds the session should be
                //It then will say "get ready" with a spinner
                //display list as many responses you can to the following prompt
                //user enters answers until selected time is up.
                //Display amount of items listed
                //display well done you have completed time of activity name
                la.Run();
                log.Add(la.WriteLog());
            }
            else if (answer == "4")
            {
                Console.WriteLine("Printing Log of current run...");
                foreach (string entry in log)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (answer == "5")
            {
               Console.WriteLine("Thank you. Goodbye."); 
            }
            else
            {
                Console.WriteLine("That is an invalid answer. Please enter a number 1 through 4.");
            }
        }
        while (answer != "5");
       
    }
}