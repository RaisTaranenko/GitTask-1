using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть шлях до файлу:");
        string filePath = Console.ReadLine();

        Console.WriteLine("Введіть значення N:");
        int n = int.Parse(Console.ReadLine());

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Dictionary<string, int> elementCounts = new Dictionary<string, int>();

            foreach (string line in lines)
            {
                if (elementCounts.ContainsKey(line))
                {
                    elementCounts[line]++;
                }
                else
                {
                    elementCounts[line] = 1;
                }
            }

            List<string> dominantElements = new List<string>();

            foreach (KeyValuePair<string, int> kvp in elementCounts)
            {
                if (kvp.Value > lines.Length / 2)
                {
                    dominantElements.Add(kvp.Key);
                }
            }

            if (dominantElements.Count > 0)
            {
                Console.WriteLine("Переважні елементи у файлі:");
                foreach (string element in dominantElements)
                {
                    Console.WriteLine(element);
                }
            }
            else
            {
                Console.WriteLine("У файлі немає переважних елементів.");
            }
        }
        else
        {
            Console.WriteLine("Файл не існує.");
        }

        Console.ReadLine();
    }
}