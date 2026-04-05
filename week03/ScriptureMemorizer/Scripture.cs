using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
            _words.Add(new Word(word));
    }

    public string GetDisplayText()
    {
        string wordDisplay = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordDisplay}";
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = GetVisibleWords();
        Random random = new Random();
        int count = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    private List<Word> GetVisibleWords()
    {
        return _words.Where(w => !w.IsHidden()).ToList();
    }
}