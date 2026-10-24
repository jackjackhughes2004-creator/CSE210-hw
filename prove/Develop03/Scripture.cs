class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public void GetDisplayText()
    {
        Console.Write($"{_reference.GetDisplayText()} ");
        foreach (Word word in _words)
        {
            word.Display();
        }
        Console.WriteLine();
    }

public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    int hiddenCount = 0;

    while (hiddenCount < numberToHide && !IsCompletelyHidden())
    {
        int index = random.Next(_words.Count);
        
        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            hiddenCount++;
        }
    }
}

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }
        return tempWords;
    }
}