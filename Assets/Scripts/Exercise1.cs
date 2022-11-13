using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    // 3 variables of numbers that u will sum
    public float x = 5;
    public float y = 2;
    public float z = 3;
    // the result of the sum
    public float result;

    private void Start()
    {
        // the sum in console
        result = x + y + z;
        Debug.Log(result);

    }
}
