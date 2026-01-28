using System;
using System.Globalization;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(int top, int bottom)
    {
        this.SetTop(top);
        this.SetBottom(bottom);
    }

    public Fraction(int wholeNumber)
    {
        this.SetTop(wholeNumber);
        this.SetBottom(1);
    }

    public Fraction()
    {
        this.SetTop(1);
        this.SetBottom(1);
    }

    public int GetTop() { return this._top; }
    public int GetBottom() { return this._bottom; }

    public void SetTop(int t) { this._top = t; }

    public void SetBottom(int b)
    {
        if (b != 0)
            this._bottom = b;
    }

    public string GetFractionString()
    {
        return $"{this.GetTop()}/{this.GetBottom()}";
    }

    public double GetDecimalValue()
    {
        return (double) this.GetTop() / this.GetBottom();
    }
}