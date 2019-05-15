using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Anoter script using the poroperty
public class AnotherScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Properties object
        Properties properties = new Properties();
        properties.Property = 45;
        Debug.Log(properties.Property);
        properties.Property1 = 55;
        Debug.Log(properties.Property1);
    }
}
