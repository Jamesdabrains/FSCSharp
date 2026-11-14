namespace RunningBunny;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Press ENTER/RETURN to run");
        Console.ReadLine();
        
        using (new RunningBunnyGame().Run()) { }
    }
}