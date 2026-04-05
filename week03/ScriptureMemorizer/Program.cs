using System;

class Program
{
    static void Main(string[] args)
    {
// Scripture Memorizer
// -----------------------------------------------------------------------
// EXCEEDING REQUIREMENTS:
// 1. SCRIPTURE LIBRARY: Uses a ScriptureLibrary class with 8 scriptures.
//    A random one is selected each time the program runs.
// 2. SMART WORD HIDING: Only hides words that are not already hidden,
//    guaranteeing progress every time the user presses Enter.
// 3. VERSE RANGES: Reference supports both single verses and verse ranges.
// -----------------------------------------------------------------------

ScriptureLibrary library = new ScriptureLibrary();
Scripture scripture = library.GetRandomScripture();

while (!scripture.IsCompletelyHidden())
{
    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();
    Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");

    string input = Console.ReadLine() ?? "";

    if (input.ToLower() == "quit")
        break;

    scripture.HideRandomWords(3);
}

Console.Clear();
Console.WriteLine(scripture.GetDisplayText());
Console.WriteLine("\nAll words are hidden. Great memorization practice!");
    }
}