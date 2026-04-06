namespace Mindfulness;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        // TODO: populate prompts list
    }

    public void Run()
    {
        // TODO: display starting message, show prompt, collect items, display count, display ending message
    }

    private string GetRandomPrompt()
    {
        return ""; // TODO: return a random prompt
    }
}
