using System;

class Program
{
    static void Main(string[] args)
    {
        Bicycles bicycles = new Bicycles("Bicycles","July 19, 2023",5,5);
        bicycles.Distance();
        bicycles.Speed();
        bicycles.Pace();
        bicycles.GetSummary();
        Running running = new Running("Running","July 19, 2023", 9, 1);
        running.Distance();
        running.Speed();
        running.Pace();
        running.GetSummary();
        Swimming swimming = new Swimming("Swimming","July 19, 2023",5,10);
        swimming.Distance();
        swimming.Speed();
        swimming.Pace();
        swimming.GetSummary();
    }
}