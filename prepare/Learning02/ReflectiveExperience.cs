class ReflectiveExperience : Experience {

    public string consider = "\nConsider the following prompt:\n";
  //public ReflectiveExperience(string consider, string prompt, string[] questions) : base(consider, prompt, questions) {}
  public ReflectiveExperience(string prompt, string[] questions) : base(prompt, questions) {}

  
  public new void Start() {
    Console.WriteLine(prompt);
    foreach (string question in questions) {
      Console.Write("Reflecting... ");
      for (int i = 0; i < 10; i++) {
        Console.Write(".");
        Thread.Sleep(100);
      }
      Console.WriteLine();
      Console.WriteLine(question);
      Thread.Sleep(2000);
    }
  }
}