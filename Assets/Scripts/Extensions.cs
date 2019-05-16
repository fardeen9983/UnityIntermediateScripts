using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create extension 
public static class ExtensionMethods
{
    //Create an extension method
    //No need to pass Transform object as argument as this will refer to the calling object itself
    public static void ResetTransformation(this Transform transform)
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
    }
}

//Use this in  a script
public class ExtensionScript : MonoBehaviour
{
    void Start()
    {
        //Call the extension method on Transform object
        transform.ResetTransformation();    
    }
}
