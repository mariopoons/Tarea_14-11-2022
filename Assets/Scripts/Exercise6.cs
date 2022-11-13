using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    // the nuber for each day of the weekend
    public int weekend = 0;

    private void Start()
    {
         /* if is less than 5, you are not in the weekend, if it's more than 7, you aren't in the week
         and if it's between 5 and 7 you are in the weekend. */
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
