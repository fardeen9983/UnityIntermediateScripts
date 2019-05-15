using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generics : MonoBehaviour
{

    GenericClass<string> genericString;
    GenericClass<int> genericInt;
    // Start is called before the first frame update
    void Start()
    {
        genericString = new GenericClass<string>();
        genericInt = new GenericClass<int>();
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (Random.Range(0, 4))
        {
            case 0 : Debug.Log(Demo.getType(4.6)); break;  
            case 1 : Debug.Log(Demo.getType<string>("hey")); break;  
            case 2 : Debug.Log(Demo.getType(5)); break;  
            case 3 : Debug.Log(Demo.getType(5.5f)); break;  
        }

        genericString.set("asd");
        Debug.Log(genericString.prop);
        genericInt.set(3);
        Debug.Log(genericInt.prop);
    }

}

//Example generic method
class Demo
{
    //T is a placeholder to be replaced by a valid type.
    public static string getType<T>(T param)
    {
        return "Type : "  + param.GetType();
    }
}

//A generic class
class GenericClass<T>
{
    public T prop;
    
    public void set(T prop) 
    {
         this.prop = prop;
    }
}


