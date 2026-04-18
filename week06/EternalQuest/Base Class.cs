public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }
public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }

    public abstract int RecordEvent(); // polymorphism
    public abstract bool IsComplete(); 
    public abstract string GetStatus();
    public abstract string GetSaveString();

}
