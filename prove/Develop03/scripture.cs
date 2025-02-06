using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
    private string _originalText;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
        _originalText = text;
    }

    public string GetDisplayText()
    {
        return $"{_reference}\n" + string.Join(" ", _words.Select(w => w.ToString()));
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        int wordsToHide = Math.Min(count, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    public bool CheckUserAttempt(string userAttempt)
    {
        return string.Equals(userAttempt.Trim(), _originalText.Trim(), StringComparison.OrdinalIgnoreCase);
    }
}