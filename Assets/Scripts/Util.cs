using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Util {
    
    static public int[] DrawWithoutRepeat(int minNum, int maxNum, int numSamples)
    {
        int[] result = new int[numSamples];
        for (int i = 0; i < numSamples; i ++)
        {
            result[i] = maxNum + 1;
        }
        for (int i = 0; i < numSamples; i++)
        {
            result[i] = Random.Range(minNum, maxNum);
            while (result.Take(i).Contains(result[i]))
            {
                result[i] = Random.Range(minNum, maxNum);
            }
        }

        return result;
    }

    static public string UppercaseFirst(string s)
    {
        // Check for empty string.
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        // Return char and concat substring.
        return char.ToUpper(s[0]) + s.Substring(1);
    }

}
