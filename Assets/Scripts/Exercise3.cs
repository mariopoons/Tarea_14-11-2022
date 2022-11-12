using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    // the name and the age of the person
    public string personName = "Juan";
    public int personAge = 20;

    private void Start()
    {
        // the phrase that will reproduce in console
        Debug.Log($" Hello {personName}! You are {personAge} years old.");
    }
}
