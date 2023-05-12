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
        if (File.Exists(fileName)){
            Console.WriteLine("It exists.");
            var appendable = new StreamWriter("./"+fileName, true);
            foreach(var entry in entries){
                appendable.WriteLine($"Date: {dateText} - Prompt: {entry._prompt}");
                appendable.WriteLine($"{entry._input}\n");
            }
        }
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
    public void journalFind()
    {
                    Console.WriteLine("What file do you want to load? ");
                    //string findJournal = Console.ReadLine();
                    string fileName = "journal.txt";
                    string [] lines = System.IO.File.ReadAllLines(fileName);
                    var pieces = new List<string>();
                    foreach (string line in lines)
                    {
                        if(line.Length != 0){
                            if(pieces.Count == 2){
                                var newEntry = new Entry(pieces[0],pieces[1]);
                                entries.Add(newEntry);
                                pieces.Clear();
                            }
                            pieces.Add(line);
                        }
                    }
                    // foreach (Entry _entry in entries)
                    // {
                    //     foreach (string line in lines)
                    // {
                    //     Console.WriteLine(line);
                    // }
                    // }
                


    }
}