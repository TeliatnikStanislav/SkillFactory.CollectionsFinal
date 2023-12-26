using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = @"C:\Users\Stanislav\Desktop";

        List<string> listCollection = new List<string>();
        LinkedList<string> linkedListCollection = new LinkedList<string>();

        string[] files = Directory.GetFiles(folderPath, "*.txt");

        Stopwatch listStopwatch = new Stopwatch();
        listStopwatch.Start();

        foreach (string file in files)
        {
            string content = File.ReadAllText(file);
            listCollection.Add(content);
        }

        listStopwatch.Stop();
        Console.WriteLine($"Вставка в List<T> заняла {listStopwatch.Elapsed}");

        listCollection.Clear();

        Stopwatch linkedListStopwatch = new Stopwatch();
        linkedListStopwatch.Start();

        foreach (string file in files)
        {
            string content = File.ReadAllText(file);
            linkedListCollection.AddLast(content);
        }

        linkedListStopwatch.Stop();
        Console.WriteLine($"Вставка в LinkedList<T> заняла {linkedListStopwatch.Elapsed}");
        Console.ReadLine();
    }
}
