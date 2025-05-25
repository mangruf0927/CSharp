using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string s)
    {
        Dictionary<string, string> numbers = new Dictionary<string, string>
        { {"one", "1"}, {"two", "2"}, {"three", "3"}, {"four", "4"}, {"five", "5"},
            {"six", "6"}, {"seven", "7"}, {"eight", "8"}, {"nine", "9"}, {"zero", "0"}};

        foreach (var num in numbers)
        {
            s = s.Replace(num.Key, num.Value);
        }
        return int.Parse(s);
    }

    public int solution2(string s)
    {
        string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < numbers.Length; i++)
        {
            s = s.Replace(numbers[i], i.ToString());
        }

        return int.Parse(s);
    }
}

