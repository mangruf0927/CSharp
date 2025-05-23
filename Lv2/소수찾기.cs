using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string numbers) 
    {
        int answer = 0;
        
        HashSet<int> hash = new HashSet<int>(); // 숫자 넣는 용도 (겹치지 않게)
        
        Permutation("", numbers, hash);

        foreach(var num in hash)
        {
            if(isPrime(num)) answer++;
        }

        return answer;
    }

    // 순열 만들기
    void Permutation(string current, string numbers, HashSet<int> hash)
    {
        if(current.Length > 0)
            hash.Add(int.Parse(current));

        for(int i = 0; i < numbers.Length; i++)
        {
            Permutation(current + numbers[i], numbers.Substring(0, i) + numbers.Substring(i + 1), hash);
        }
    }

    // 소수인지 판별
    bool isPrime(int number)
    {
        if(number < 2) return false;

        for(int i = 2; i < number; i++)
        {
            if(number % i == 0) return false;
        }

        return true;
    }
}
