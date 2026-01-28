using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.SetBook(book);
        this.SetChapter(chapter);
        this.SetVerse(verse);
    }

    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse;
        this._endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string reference = $"{this._book} {this._chapter}:{this._verse}";
        return this._endVerse != 0
                ? reference += $"-{this._endVerse}"
                : reference;
    }
    public void SetBook(string book)
    {
        this._book = book;
    }
    public void SetChapter(int chapter)
    {
        this._chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        this._verse = verse;
    }
    public void SetEndVerse(int endVerse)
    {
        this._endVerse = endVerse;
    }
}