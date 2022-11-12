using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    // 
    public int weekend = 0;

    private void Start()
    {
         
        if (weekend < 5)
        {
            Debug.Log($"Day {weekend} does not belogs to the weekend.");
        }
       else if (weekend > 7)
        {
            Debug.Log("This day is not in the week.");
        }
        else
        {
            Debug.Log($"Day {weekend} belong to the weekend");
        }
    }
}
