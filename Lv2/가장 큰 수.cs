using System;

public class Solution 
{
    public string solution(int[] numbers) 
    {
        string[] temp = new string[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
            temp[i] = numbers[i].ToString();

        Array.Sort(temp, (a, b) => (b + a).CompareTo(a + b));

        if (temp[0] == "0")
            return "0";
        else
            return string.Concat(temp);
    }
}
