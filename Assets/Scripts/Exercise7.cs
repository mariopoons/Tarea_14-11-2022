using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    // the letter that you put here will say if it's vowel or not :))
    public string letter = "";

    private void Start()
        // this tells if the letter that you put is vowel or consonant.
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        { 
            Debug.Log($" The letter {letter} is a vowel");
        }
        else
        {
            Debug.Log($"The letter {letter} is a consontant");
        }
    }
}
