using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    // the letter that you put here will say if it's vowel or not :))
    public string letter = "";

    private void Start()
        /* I know that this is not what you have said in clas Maria, but is the only way that
        I find for doing it xd*/
        // this tells if the letter that you put is vowel or consonant.
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
