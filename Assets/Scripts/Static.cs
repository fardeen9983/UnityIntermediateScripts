using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    
    void FixedUpdate()
    {
        if (Random.Range(1, 101) % 2 == 0)
            Counter.count += 2;
        else
            Counter.count++;
        print(Counter.count);
    }
}

static class Counter
{
    public static int count = 0;
}