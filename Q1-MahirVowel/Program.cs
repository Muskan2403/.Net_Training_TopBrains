using System;

class Program
{
    public static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        
        string vowels = "aeiouAEIOU";
        string result = "";

        foreach (char c in word1)
        {
            char lowerC = Char.ToLower(c);
            if ((vowels.Contains(c)) || !word2.ToLower().Contains(lowerC))
            {
                result += c;
            }
        }

        string finalResult = "";
        char prevChar = '\0';
        foreach (char c in result)
        {
            if (c != prevChar)
            {
                finalResult += c;
                prevChar = c;
            }
        }

        Console.WriteLine(finalResult);
    }
}
