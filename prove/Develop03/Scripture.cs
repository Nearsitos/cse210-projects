using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference);
        Console.WriteLine(string.Join(" ", words));
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = Math.Min(3, words.Count(w => !w.IsHidden()));

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();
            if (visibleWords.Count == 0) break;

            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
