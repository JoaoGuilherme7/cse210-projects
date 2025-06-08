using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        this._text = word;
        this._isHidden = false;
    }

    public void Hide()
    {
        this._isHidden = true;
    }

    public void Show()
    {
        this._isHidden = false;
    }

    public bool IsHidden()
    {
        return this._isHidden;
    }

    public string GetDisplayText()
    {
        return this.IsHidden()
                ? new string('_', this._text.Length)
                : this._text;
    }
}