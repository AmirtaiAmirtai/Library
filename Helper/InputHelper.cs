using System;

public class InputHelper
{
    public static string ReadString(string inputMessage)
    {
        Console.WriteLine(inputMessage);
        string? value = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        Console.WriteLine("Damn Son enter some letters ");
        return ReadString(inputMessage);
    }

    public static int ReadNumber(string inputMessage)
    {
        string value = ReadString(inputMessage);
        if (int.TryParse(value, out int number))
        {
            return number;
        }

        Console.WriteLine("Digits Mason!!!");
        return ReadNumber(inputMessage);
    }
}
