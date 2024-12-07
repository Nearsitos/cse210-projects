using System;

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        return endVerse.HasValue
            ? $"{book} {chapter}:{startVerse}-{endVerse}"
            : $"{book} {chapter}:{startVerse}";
    }
}
