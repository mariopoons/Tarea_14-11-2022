using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Exercise10 : MonoBehaviour

{
    // the variable for doing the multiplication table
    public int x = 2;
    

    private void Start()
    {
        // the code of the multiplication table 
        if (x == 2)
        Debug.Log($"{x} * {1} = { x * 1}");
        Debug.Log($"{x} * {2} = { x * 2}");
        Debug.Log($"{x} * {3} = { x * 3}");
        Debug.Log($"{x} * {4} = { x * 4}");
        Debug.Log($"{x} * {5} = { x * 5}");
        Debug.Log($"{x} * {6} = { x * 6}");
        Debug.Log($"{x} * {7} = { x * 7}");
        Debug.Log($"{x} * {8} = { x * 8}");
        Debug.Log($"{x} * {9} = { x * 9}");
        Debug.Log($"{x} * {10} = { x * 10}");
        


    }
}