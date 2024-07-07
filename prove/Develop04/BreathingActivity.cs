class BreathingActivity : Activity
{
    public BreathingActivity() 
        :base()
    {
        _name = "Breathing";
        _description = "This activity will walk you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

   public void Run()
   {
        
        DisplayStartingMessage();
        
        Console.Write("How long in seconds would you like for your session? ");
        string input = Console.ReadLine();

        _duration = Convert.ToInt32(input);

        Console.WriteLine("Get Ready...");
        ShowSpinner(10);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath In...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breath Out..");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(5);
   } 
}