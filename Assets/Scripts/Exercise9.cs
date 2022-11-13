using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise9 : MonoBehaviour
{
    // the amount of candy available
    public int candyAvailable = 62;
    // the number of people to give candy to.
    public int toGiveCandy = 29;
    private int result;

    private void Start()

    {
        // the division of the total candy and the person to give candy
        result = candyAvailable / toGiveCandy;
        Debug.Log($"Each person takes {result} candies");

        // the rest of the candies available
        result = candyAvailable % toGiveCandy;
        Debug.Log($"{result} candies are left");
    }
}
