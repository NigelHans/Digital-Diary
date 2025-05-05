using System;
using System.IO;
using System.Net;

public class Diary
{
    private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "diary.txt");

    public void WriteEntry(string text)
    {
        using (StreamWriter sw = new StreamWriter(filePath, append: true))
        {
            string entry = $"[{DateTime.Now:yyyy-MM-dd}] [{DateTime.Now:HH:mm:ss}] {text}";
            sw.WriteLine(entry);
        }
        Console.WriteLine("Entry saved successfully!");
    }

    public void ViewAllEntries()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No diary entries found.");
            return;
        }

        string[] entries = File.ReadAllLines(filePath);
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SearchByDate(string date)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No diary entries found. ");
            return;
        }
        
        string[] entries = File.ReadAllLines(filePath);
        bool found = false;

        foreach (string entry in entries)
        {
            if (entry.StartsWith($"[{date}]"))
            {
                Console.WriteLine(entry);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No entries found for the given date. ");
        }
    }
}
