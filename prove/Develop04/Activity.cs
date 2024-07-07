public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        //This needs to display the name of the activity and description
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        //display well done you have completed time of activity name
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Console.WriteLine();
    }
    
    public void ShowSpinner(int seconds)
    {
         //It then will say "get ready" with a spinner
        List<string> spinnerList = new List<string>{"|","/","-","\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerList[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerList.Count)
            {
                i = 0;
            }
        } 
    }

    public void ShowCountDown(int seconds)
    {
        //Countdowns when needed
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public string WriteLog()
    {
        DateTime time = DateTime.Now;
        return $"{time} - The activity {_name} was ran for a duration of {_duration}.";
    }
}