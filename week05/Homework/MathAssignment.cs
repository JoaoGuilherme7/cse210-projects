using System;

class MathAssignment : Assignment
{
    private string _textBook;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBook, string problems) : base(studentName, topic)
    {
        this._textBook = textBook;
        this._problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {this._textBook} Problems {this._problems}";
    }
}
