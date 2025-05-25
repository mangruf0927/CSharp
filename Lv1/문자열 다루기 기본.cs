public class Solution 
{
    public bool solution(string s) 
    {
        if (s.Length == 4 || s.Length == 6)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if ( s[i] < '0' || '9' < s[i])
                {
                    return false;
                }
            }

            return true;
        }

        return false;
    }
}

  
