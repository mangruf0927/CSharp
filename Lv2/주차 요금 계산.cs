using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] fees, string[] records)
    {
        List<int> answer = new List<int>();
        Dictionary<string, string> parks = new Dictionary<string, string>();
        Dictionary<string, int> carFees = new Dictionary<string, int>();

        for (int i = 0; i < records.Length; i++)
        {
            string[] current = records[i].Split(" ");

            if (!parks.ContainsKey(current[1]))
            {
                parks.Add(current[1], current[0]); // 차량번호 - 시간 입력
            }
            else
            {
                int time = CalculateTime(parks[current[1]], current[0]);
                parks.Remove(current[1]);

                if (!carFees.ContainsKey(current[1]))
                {
                    carFees[current[1]] = time; 
                }
                else
                {
                    carFees[current[1]] += time; 
                }
            }
        }

        if (parks.Count > 0)
        {
            foreach (var car in parks)
            {
                int time = CalculateTime(car.Value, "23:59");

                if (!carFees.ContainsKey(car.Key))
                {
                    carFees[car.Key] = time;
                }
                else
                {
                    carFees[car.Key] += time; 
                }
            }
        }



        foreach (var car in carFees.Keys.OrderBy(x => x))
        {
            answer.Add(CalculateFee(carFees[car], fees));
        }

        return answer.ToArray();
    }

    public int CalculateTime(string inTime, string outTime)
    {
        string[] inTimes = inTime.Split(":");
        string[] outTimes = outTime.Split(":");

        int minutes = int.Parse(outTimes[0]) * 60 + int.Parse(outTimes[1]) - (int.Parse(inTimes[0]) * 60 + int.Parse(inTimes[1]));

        return minutes;
    }

    public int CalculateFee(int time, int[] fees)
    {
        if (time <= fees[0]) return fees[1];
        else return fees[1] + (int)Math.Ceiling((double)(time - fees[0]) / fees[2]) * fees[3];
    }
}
