class Save
{
    public void Save(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetSaveString());
            }
        }
    }
}