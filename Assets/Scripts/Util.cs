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

}
