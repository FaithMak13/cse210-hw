public class FileLoader
{
    public void Load(string file)
    {
        string[] lines = File.ReadAllLines(file);

    _score = int.Parse(lines[0]);
    _goals.Clear();

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split("|");

            if (parts[0] == "Simple")
            {
                // rebuild SimpleGoal
            }
            else if (parts[0] == "Eternal")
            {
                // rebuild EternalGoal
            }
            else if (parts[0] == "Checklist")
            {
                // rebuild ChecklistGoal
            }
        }
    }
}