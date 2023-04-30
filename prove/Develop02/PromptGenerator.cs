using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public static string[] _prompt =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one act of kindness you performed today?",
        "When did you feel the spirit the strongest today?",
        "Name three things you are grateful for.",
        "Who is your most favorite person to spend time with?",
        "When was the last time you told someone you loved them? Who was it?",
        "What brings you joy?",
        "Did you pray today?",
        "Share your favorite scripture passage.",
        "What was your favorite talk in conference?"

        };

    public List<string> _jPrompts = new List<string>(_prompt);


    public PromptGenerator()
    {

    }



    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_jPrompts.Count);
        string journalPrompt = _jPrompts[index];

        return journalPrompt;
    }

}