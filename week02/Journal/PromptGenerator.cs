using System;

public class PromptGenerator
{
    public List<string> _prompts = [
        "What made you happy today?",
        "What did you learn today?",
        "What are you grateful for?"];

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}