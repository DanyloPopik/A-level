using HW_27._10;

class Program
{
    static void Main(string[] args)
    {
        Starter starter = new Starter();
        starter.Run();
        var LogEntries = Logger.Instance.GetLogEntries();
        File.WriteAllLines("Log.txt", LogEntries);
        Console.WriteLine("Log is saved");
    }
}





