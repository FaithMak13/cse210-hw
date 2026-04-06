namespace Mindfulness;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        // TODO: show name, description, ask user for duration, set _duration
    }

    public void DisplayEndingMessage()
    {
        // TODO: pause, display "Good job!" message with name and duration
    }

    public void ShowSpinner(int seconds)
    {
        // TODO: animate spinner for given seconds
    }

    public void ShowCountDown(int seconds)
    {
        // TODO: count down from seconds to 0
    }
}
