using System;
using System.Threading;

class Experience {
  //protected string consider;
  protected string prompt;
  protected string[] questions;

  //public Experience(string consider, string prompt, string[] questions) {
  public Experience(string prompt, string[] questions) {
    //this.consider = consider;
    this.prompt = prompt;
    this.questions = questions;
  }

  public void Start() {
    //Console.WriteLine(consider);
    Console.WriteLine(prompt);
    foreach (string question in questions) {
      Console.WriteLine(question);
    //   for (int i = 5; i > 0; i--)
    //         {
    //             //Console.Write($"{i}...");
    //             Console.Write(i);
    //             Thread.Sleep(1000);
    //             Console.Write("\b \b");
    //         }
      //Thread.Sleep(3000);
      List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }
  }
}