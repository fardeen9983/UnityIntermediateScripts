using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutliCastDelegates : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate multiDelegate;
    // Start is called before the first frame update
    void Start()
    {
        //Multicast delegate to two methods
        multiDelegate += push;
        multiDelegate += redColor;
        //Invoke both functions
        multiDelegate();

        //Remove a method
        multiDelegate -= redColor;
        multiDelegate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function to push the ball
    void push()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 5000);
    }

    //Change color to red
    void redColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
