using System;

class program
{
    private int id;
    private string title;
    private int playCount;

    public program(string title)
    {
        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999); // generate 5-digit random number
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int count)
    {
        // Precondition
        if (count > 10000000 || count < 0)
        {
            throw new ArgumentOutOfRangeException("count", "Invalid input. Count must be between 0 and 25,000,000.");
        }
        this.playCount += count;

        // Postcondition
        if (this.playCount < 0)
        {
            throw new Exception("Postcondition failed: Play count cannot be negative.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            program video = new program("Tutorial Design By Contract - [Kevin]");

            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(100000); // testing precondition
            }

            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.ReadKey();
    }
}