using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        string reversedSentence = ReverseSentence(sentence);
        Console.WriteLine("Речення в зворотньому порядку: " + reversedSentence);
    }

    static string ReverseSentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}