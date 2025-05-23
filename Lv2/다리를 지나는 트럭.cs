using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int bridge_length, int weight, int[] truck_weights) 
    {
        int time = 0;
        int count = 0;
        int totalWeight = 0;

        Queue<int> bridgeTruck = new Queue<int>();

        while (count < truck_weights.Length)
        {
            if (bridgeTruck.Count == bridge_length)
            {
                totalWeight -= bridgeTruck.Dequeue();
            }

            if (totalWeight + truck_weights[count] <= weight)
            {
                bridgeTruck.Enqueue(truck_weights[count]);
                totalWeight += truck_weights[count];
                count++;
            }
            else
            {
                bridgeTruck.Enqueue(0);
            }

            time++;
        }

        return time + bridge_length;
    }
}
