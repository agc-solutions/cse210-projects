using System;
public class References
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _verseEnd;


    public References()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
}
}