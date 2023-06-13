using System;
public class Reference
{
    public static Book _rndPpt = new Book();

    private string _book;
    private int _chapter;
    private int _verseInit;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseInit)
    {
        _book = book;
        _chapter = chapter;
        _verseInit = verseInit;
        _verseEnd = 0;
    }
    public Reference (string book, int chapter, int verseInit, int verseEnd)
     {
        _book = book;
        _chapter = chapter;
        _verseInit = verseInit;
        _verseEnd = verseEnd;
    }

    public string GetReferenceText()
    {
        if(this.GetVerseEnd() != 0) 
        {
            return ($"{this.GetBook()} {this.GetChapter()}:{this.GetVerseInit()}-{this.GetVerseEnd()}");
        }
        else
        {
            return ($"{this.GetBook()} {this.GetChapter()}:{this.GetVerseInit()}");
        }

    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerseInit()
    {
        return _verseInit;
    }
    public int GetVerseEnd()
    {
        return _verseEnd;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _verseInit = verse;
    }
    public void SetVerseEnd(int verseEnd)
    {
        _verseEnd = verseEnd;
    }


    // private string book {get; set; }
    // private int chapter {get; set; }
    // private int verseInit {get; set; }
    // private int verseEnd {get; set; }

    
    // public override string ToString()
    // {
    //     //return $"{Book} {Chapter}:{VerseInit}";
    //     return $"{book} {chapter}:{verseInit} {verseEnd}";
    // }
}