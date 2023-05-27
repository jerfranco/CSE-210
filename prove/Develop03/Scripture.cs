public class Scripture
{
    List<string> _words;
    Words w = new Words();
    List<string> _hiddenWords;
    Reference _rf;

    // public void entryWords(Words words)
    // {
    //     _words.Add(words);
    // }

    public Scripture(Reference refer, List<string> words)
    {
        
        
        _words = words;
        _rf = refer;


    }
    
    public void HideRandomWord()
    {



    }

    public void Display()
    {
        foreach (string word in _words)
        {
            // foreach (string hword in _hiddenWords)
            // {
            //     if (hword.Contains(word))
            //     {
            //         Console.Write("_____");
            //     }
            // }
            //if word is in the hidden list, replace it with ____
            Console.Write($" {word}");
            w.HideWord();
        }


    }

    public void IsVerseDone()
    {



    }

}