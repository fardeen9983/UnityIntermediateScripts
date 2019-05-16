using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Delegates : MonoBehaviour
{

    //A generic delegate
    delegate void SampleDelegate<T>(T num);
    SampleDelegate<string> stringDelegate;

    // Start is called before the first frame update
    void Start()
    {
        //Assign a function to the delegate
        stringDelegate = printString;
        //Call the function via the delegate
        stringDelegate("Hey there");

        //Another Function assigned to the delegate
        stringDelegate = printStringTwice;
        stringDelegate("One Two");

        stringDelegate = printStringToInt;
        stringDelegate("545:8");
        stringDelegate("545.8");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void printString(string x)
    {
        Debug.Log(x);
    }

    void printStringTwice(string y)
    {
        Debug.Log(y +" "+ y);
    }

    void printStringToInt(string z)
    {
        float num; 
        bool temp = float.TryParse(z,out num);
        Debug.Log("Numeric equivalent : " + (temp ? num.ToString() : " Invalid number "));
    }
}
