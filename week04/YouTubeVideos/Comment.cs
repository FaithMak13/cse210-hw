using System;
using System.Collections.Generic;   

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }
    private string _author;
    private string _text;
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
        _author = commenterName;
        _text = text;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public string GetText()
    {
        return _text;
    }
}