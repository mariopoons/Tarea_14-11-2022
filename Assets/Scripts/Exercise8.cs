using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
    public string month = "";

    private void Start()
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
