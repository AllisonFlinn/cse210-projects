using System;

namespace promptGenerator
{
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
}