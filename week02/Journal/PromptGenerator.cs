public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"What was your most positive interaction today?", "What is a current challenge you are facing?", "What are you grateful for that happened today?", "What was the best part of your day?", "If there was one thing you could do over today what would it be?", "How did you see the hand of the lord in your life today?", "What has been on your mind today?"};

    public string GetRandomPrompt()
    {  
        Random random = new Random();
        int randomNumber = random.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
}   