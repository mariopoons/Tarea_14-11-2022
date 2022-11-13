using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
    // a space for writting the month that you want
    public string month = "";

    private void Start()
    /* if you type a month ending in 31 then it will say the first sentence, if you type a month
    that end in 30, then it will say the second sentence and if you say a month that ends in 28 then
    it will say the last sentence */
    {
        if (month is "january" or "march" or "may" or "july" or "august" or "october" or "december")
        {
            Debug.Log($"{month} has 31 days.");
        }
        else if (month is "april" or "june" or "september" or "november")
        {
            Debug.Log($"{month} has 30 days.");
        }
        if (month is "february")
        { 
            Debug.Log($"{month} has 28 days.");
        }
    }
    
}
