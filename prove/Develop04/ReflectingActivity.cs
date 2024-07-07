class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    static Random _rnd = new Random();
    public ReflectingActivity() 
        :base()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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
        Console.WriteLine("Consider the following prompt.");
        Console.WriteLine();
        DisplayPrompt();
        DisplayQuestions();
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);
   } 

   public string GetRandomPrompt()
   {
        int r = _rnd.Next(_prompts.Count);
        return _prompts[r];
   } 

   public string GetRandomQuestion()
   {
        int r = _rnd.Next(_questions.Count);
        return _questions[r];
   } 

    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
        ShowSpinner(_duration/2);
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
        ShowSpinner(_duration/2);
        Console.WriteLine();
    }
}