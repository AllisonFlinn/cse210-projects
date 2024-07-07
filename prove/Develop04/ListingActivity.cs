using Microsoft.VisualBasic;

class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    static Random _rnd = new Random();
    public ListingActivity() 
        :base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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
        GetRandomPrompt();
        List<string> responses = GetListFromUser();
        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
   } 

   public void GetRandomPrompt()
   {
        int r = _rnd.Next(_prompts.Count); 
        Console.WriteLine(_prompts[r]);
   }
       
   public List<string> GetListFromUser()
   {
        List<string> userList = new List<string> ();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            userList.Add(input);
        }
        return userList;
   }
}