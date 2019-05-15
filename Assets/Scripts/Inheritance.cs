using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    Rectangle rectangle;
    Square square;
    // Start is called before the first frame update
    void Start()
    {
        rectangle = new Rectangle(3.0f, 6.0f);
        Debug.Log("Area : " + rectangle.area());
        square = new Square(4.0f);
        Debug.Log("Area : " + square.area());
        //Super class reference can refer to sub class object but can only access the inherited not the unique members
        //But here area method of square will be called as it overrides the one in rectangle class
        rectangle = new Square(7.0f);
        Debug.Log("Area : " + rectangle.area());
    }

}

//Super class
class Rectangle
{
    float length, width;

    public Rectangle(float length, float width) { this.length = length;  this.width = width;  }
    public float area() { return length * width;  }
}

//Inheriting Rectangle class
class Square : Rectangle
{
    float side;
    //Before executing it's own constructor sub class has to invoke super class constructor
    public Square(float side) : base(side, side) { this.side = side;  }

    //Hide superclass method of the same name
    public float area() { return side * side;  }
}