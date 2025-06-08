using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._words = this.TextToWords(text);
    }
    private List<Word> TextToWords(string text)
    {
        List<Word> words = text
        .Split(' ')
        .Select(wordStr => new Word(wordStr))
        .ToList();

        return words;

    }
    public void HideRandonWords(int numberToHide)
    {
        int i = 0;
        while (i < numberToHide)
        {
            int index = new Random().Next(0, this._words.Count);
            Word word = this._words[index];
            if (!word.IsHidden())
            {
                word.Hide();
                i++;
                if (this.IsCompletelyHidden())
                    i = numberToHide;

            }
        }

    }
    public string GetDisplayText()
    {
        string text = $"{this._reference.GetDisplayText()} ";
        foreach (Word word in this._words)
        {
            text += $"{word.GetDisplayText()} ";
        }

        return text;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in this._words)
        {
            if (!word.IsHidden())
                return false;
        }

        return true;
    }
}