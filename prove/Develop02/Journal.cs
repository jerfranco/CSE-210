using System.IO;
using System.Collections.Generic;
public class Journal
{
    //we put the list of entries in Journal because it holds the list of entries
    List<Entry> entries = new List<Entry>();
    public void entryInput(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        foreach(Entry entry in entries)
        {
            Console.WriteLine($"\nDate: {dateText} - Prompt: {entry._prompt}");
            Console.WriteLine(entry._input);
        }
        
    }

    public void journalSave()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string fileName = "";
        Console.WriteLine("What do you want to name the file? ");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in entries)
        {
            outputFile.WriteLine($"Date: {dateText} - Prompt: {entry._prompt}");
            outputFile.WriteLine($"{entry._input}\n");
        }
        }
    }

    /*public void journalLoad()
    {
        Console.WriteLine("What file do you want to load? ");
        string findJournal = Console.ReadLine();
    }*/
    public static List<Entry> journalfind()
    {
                    List<Entry> entry = new List<Entry>();
                    Console.WriteLine("What file do you want to load? ");
                    //string findJournal = Console.ReadLine();
                    string fileName = "journal.txt";
                    string [] lines = System.IO.File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    
                    return entry;
                    // foreach (Entry _entry in entries)
                    // {
                    //     foreach (string line in lines)
                    // {
                    //     Console.WriteLine(line);
                    // }
                    // }
                


    }
}