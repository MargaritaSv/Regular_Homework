using System;
using System.Text.RegularExpressions;

class ValidUserName
{
    static void Main()
    {
        string input = Console.ReadLine();
        string valid = @"\b[a-zA-Z]\w{3,25}\b";

        Regex rg = new Regex(valid);
        MatchCollection mts = rg.Matches(input);
        int max = int.MinValue;
        int fIndex = 0;
        int secIndex = 0;

        for (int i = 0; i < mts.Count - 1; i++)
        {
            int temp = mts[i].Length + mts[i + 1].Length;

            if (temp > max)
            {
                max = temp;
                fIndex = i;
                secIndex = i + 1;
            }
        }
        Console.WriteLine(mts[fIndex]);
        Console.WriteLine(mts[secIndex]);
    }
}
