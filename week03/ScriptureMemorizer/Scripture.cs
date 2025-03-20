class Scripture
{
    private Reference _reference;
    private List<Word>_words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    for (int i = 0; i < numberToHide; i++)
    {
        // create a list of index for non hidden words
        List<int> notHiddenIndexes = new List<int>();
        for (int j = 0; j < _words.Count; j++)
        {
            if (!_words[j].isHidden())
            {
                notHiddenIndexes.Add(j);
            }
        }

        // if there's no words to hide, exit
        if (notHiddenIndexes.Count == 0) return;

        // select a random index from the list of indexes of non hidden words
        int randomIndex = notHiddenIndexes[random.Next(notHiddenIndexes.Count)];

        // hide the word in the random index
        _words[randomIndex].Hide();
    }
}

public string GetDisplayText()
{
    string referenceText = _reference.GetDisplayText(); // Obtain the text of the reference
    System.Text.StringBuilder displayText = new System.Text.StringBuilder();
    foreach (Word word in _words)
    {
        displayText.Append(word.GetDisplayText());
        displayText.Append(" ");
    }
    return $"{referenceText} - {displayText.ToString().Trim()}"; // Includes the reference in the result
}

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                allHidden = false;
                break;
            }
        }
        return allHidden;
    }
}