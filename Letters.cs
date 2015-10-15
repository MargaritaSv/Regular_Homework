using System;
using System.Text.RegularExpressions;

class Letters
    {
        static void Main()
        {
        string input = Console.ReadLine().Trim();
        input = RemoveDublicateChar(input);
        Console.WriteLine(input);
        }

    private static string RemoveDublicateChar(string input)
    {
        string pattern = @"(\w)\1";
        Regex reg = new Regex(pattern);
        Match match = reg.Match(input);

        while (match.Success)
        {
            input = input.Replace(match.ToString(), match.ToString()[0].ToString());
            match = reg.Match(input);
        }

        return input;
    }
}
