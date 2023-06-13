public class ReflQuestions2
{
    public string _chosen2;
    public void Qstns()
    {
        string[] questions2 = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random rnd2 = new Random();
        int r = rnd2.Next(questions2.Length);
        _chosen2 = (questions2[r]);

    }
}