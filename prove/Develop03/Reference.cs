public class Reference
{
    public static Book _rndPpt = new Book();



    private string book {get; set; }
    private int chapter {get; set; }
    private int verseInit {get; set; }
    private int verseEnd {get; set; }

    public Reference (string book, int chapter, int verseInit, int verseEnd)
    {
        // Book = book;
        // Chapter = chapter;
        // VerseInit = verseInit; 
        // VerseEnd = verseEnd;       
    }

    public override string ToString()
    {
        //return $"{Book} {Chapter}:{VerseInit}";
        return $"{book} {chapter}:{verseInit} {verseEnd}";
    }
}