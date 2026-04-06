namespace Mindfulness;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        // TODO: populate prompts and questions lists
    }

    public void Run()
    {
        // TODO: display starting message, show random prompt, display questions, display ending message
    }

    private string GetRandomPrompt()
    {
        return ""; // TODO: return a random prompt
    }

    private void DisplayQuestions()
    {
        // TODO: loop through questions with spinner pauses
    }
}
