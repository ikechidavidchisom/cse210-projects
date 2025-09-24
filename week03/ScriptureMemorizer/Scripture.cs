using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in verseText.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hidden = 0;

        while (hidden < count)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string verse = "";
        foreach (Word word in _words)
        {
            verse += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} - {verse.Trim()}";
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
