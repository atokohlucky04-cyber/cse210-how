using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // A list to store multiple Entry objects
    public List<Entry> _entries = new List<Entry>();

    // Method to add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("-----------------------------------");
        }
    }

    // Method to save the journal to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    // Method to load the journal from a file
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
    }
}