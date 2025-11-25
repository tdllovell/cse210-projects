using System.IO;
namespace Develop02;

public class FileMnger
{
    private string _fileName;
    public FileMnger() { }

    public void SaveEntries(List<Entry> entries)
    {
        Console.WriteLine("What name would you like to give the file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.CreateFileOutput());
            }
        }
    }

    public List<Entry> LoadEntries()
    {
        List<Entry> entries = new List<Entry>();
        Console.WriteLine("What is the name of the file? ");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("`");
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            entries.Add(entry);
        }
        return entries;
    }

}
