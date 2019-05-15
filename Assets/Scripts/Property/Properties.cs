using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    //Properties are variables with access modifiers: public, protected and private
    //They can be accessed and modified directly (if public) or through getter and setter methods

    //This is a private property cannot be accessed directly by dot operator
    private int property;
    //Define getters and setters for it
    //Convention : Create a variable of same name with capital initial
    public int Property1
    {
        //property accessors
        get
        {
            //Other code
            return property;
        }
        set
        {
            //Other code
            property = value;
        }
    }
    
    //Short hand synatx
    public int Property { get; set; }
}



