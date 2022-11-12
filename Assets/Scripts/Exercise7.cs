using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public string letter = "";

    private void Start()
    {
        if (letter is "a" or "e" or "i" or "o" or "u")
        { 
            Debug.Log($" The letter {letter} is a vowel");
        }
        else
        {
            Debug.Log($"The letter {letter} is a consontant");
        }
    }
}
