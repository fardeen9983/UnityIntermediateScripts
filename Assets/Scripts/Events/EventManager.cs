using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //Declare a delegate to define event signature for any movement of object
    public delegate void OnMove(Vector3 vector,Transform transform);
    //Create an event for left/right/up/down motion
    public static event OnMove onMove;
    // Start is called before the first frame update
    public static void execute(Vector3 vector,Transform transform)
    {
        onMove?.Invoke(vector,transform);
    }
}
