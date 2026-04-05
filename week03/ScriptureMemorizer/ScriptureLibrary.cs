using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _random = new Random();
        _scriptures = new List<Scripture>();
        LoadScriptures();
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    private void LoadScriptures()
    {
        _scriptures.Add(new Scripture(new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"));

        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"));

        _scriptures.Add(new Scripture(new Reference("Joshua", 1, 9),
            "Have not I commanded thee Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest"));

        _scriptures.Add(new Scripture(new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"));

        _scriptures.Add(new Scripture(new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be and men are that they might have joy"));

        _scriptures.Add(new Scripture(new Reference("Doctrine and Covenants", 18, 10),
            "Remember the worth of souls is great in the sight of God"));

        _scriptures.Add(new Scripture(new Reference("Matthew", 5, 14, 16),
            "Ye are the light of the world A city that is set on an hill cannot be hid Neither do men light a candle and put it under a bushel but on a candlestick and it giveth light unto all that are in the house Let your light so shine before men that they may see your good works and glorify your Father which is in heaven"));

        _scriptures.Add(new Scripture(new Reference("Moroni", 10, 4),
            "And when ye shall receive these things I would exhort you that ye would ask God the Eternal Father in the name of Christ if these things are not true and if ye shall ask with a sincere heart with real intent having faith in Christ he will manifest the truth of it unto you by the power of the Holy Ghost"));
    }
}