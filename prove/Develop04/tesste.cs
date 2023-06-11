public class teste
{
    private string _teste;
    public void DisplayTeste()
    {
        Console.WriteLine("Welcome to the Breathing Exercise activity!");
        Console.Write("Please enter the duration of the exercise in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ");

        //Console.Write("\nThe execise will start in...");
        Console.Write("\nGet ready...");
        for (int i = 5; i > 0; i--)
        {
            //Console.Write($"{i}...");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("\nSTART!");
        int seconds = 0;
        do
        {
            Console.Write("\nBreathe in...");
            for (int i = 5; i > 0; i--)
            {
                //Console.Write($"{i}...");
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nNow breathe out...");
            for (int i = 5; i > 0; i--)
            {
                //Console.Write($"{i}...");
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            seconds+=10;
            }while (seconds < duration);
            Console.WriteLine($"\n\nWell done! \nYou have completed abother {duration} seconds of the Breathing Activity.");
            Console.ReadLine();
            
        

        // Console.WriteLine("Breathe in...");
        // Thread.Sleep(5000);
        // Console.WriteLine("Breathe out...");
        
    }
}