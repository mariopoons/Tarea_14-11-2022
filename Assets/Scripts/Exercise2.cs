using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // the name and the city of the person 
    public string name = "Mario";
    public string city = "Palma";

    private void Start()
    {
        // the phrase that will say in console
        Debug.Log($"Hello {name}! Welcome to {city}.");
    }
}
