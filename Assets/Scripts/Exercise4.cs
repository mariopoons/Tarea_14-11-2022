using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    // the birthday, the current year and the person age
    public int birthYear = 2002;
    public int currentYear = 2022;
    public int personAge = 00;

    private void Start()
    {
        // the phrase that will reproduce in console
        Debug.Log($"If we are in the {currentYear} and you born in {birthYear}, you are {personAge = currentYear - birthYear} " +
                  $"years old.");
    }
}
