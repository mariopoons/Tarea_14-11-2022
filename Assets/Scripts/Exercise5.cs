using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    // tells if the x is bigger than the y
    public int x = 0;
    public int y = 0;
    //
    private bool isBigger;

    private void Start()
    {
        // the code of if the x is bigger than the y
        isBigger = x > y;
        Debug.Log(isBigger);
    }
}
