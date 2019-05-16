# UnityIntermediateScripts
## Property : 
Benefit of using Properties instead of private properties is that 
1. Through combinations of getter and setter we can create either read-only, write-only or both types of properties.
2. Getters and setter can have other lines of code opening up to using coroutines.
### Ternary Operator :
Acts on three operands.
1. A condition
2. The set of statements to execute if the condition is true
3. The set of statements to execute if the condition is false

Example:
```c#
int clip = 10;
string msg = clip > 0 ? "Clip ready" : "Reload!!";
```
## Static :
Variables and methods of a class declared as static are created only once per class and not for each object.

They can be directly accessed through class name. No need to create an object for that.

Their value thus persists across the objects of the class.

A class can itself be made static in which case it cannot be instantiated. Useful when the class is made up of static members only.
## Method overloading :
It allows us to create functions of the same but different no and types of arguments and maybe different body as well.

The fucntion version to be called is determined based on the arguments past and hence return type doesn't count as an identifier for which method to call.

If no exact match is found then compiler relies on typecasting lower values to higher class and then find a suitable match, which if still not found will return an error

Example :
```c#
//Sum of two numbers
int add(int a,int b) { return a + b; }
//Concatenation of strings
string add(string a, string b) { return a + b; }
```
## Generics :
It allows methods and classes to work with any type of data. Unlike method arguments the types of generic data is not predefined and it can hold any class and other data.

Example:
```c#
Renderer renderer = GetComponent<Renderer>()
```
The GetComponent method takes a type as an argument and returns a component reference matching the given type.

We cannot perform many operations on the Generic types as their behaviour is unknown. But we can place constraint on Generic values to easily perform operations. These constraints are :
1. class - To see if T is a class
1. struct - To see if T is a strucutre
1. new() - To see if T has a no-arg constructor
1. MonoBehaviour - To see if T is an object of particular class

Example
```c#
T GenericMethod<T>(T param) where T : constraint
{
    //sone code
    return param;
}
```
## Inheritance and Polymorphism
It is OOP concept allowing one class to inherit from other class it's public and private members usingthe ' : ' operator. 

The class being inherited is called super/base class and the one inheriting it is called the sub/derived class.

base keyword is used to access base class methods from derived class.

To stop overriding we can place ' new ' keyword infront of child class members with same name as parent class, this will call the parent class version of the member no matter if we use the child class object
## Overriding
Whenever the members of base class are redefined by the child class they are practically hidden. So the child method will now all only it's version of parent class members.

But simply redefining them isn't sufficient as the C# compiler will complain of method overriding

In such scenarios we can specify the parent method to be virtual. If the child class wants to redefine this method they will have to override it, or else the parent method will be called.
## Interface
These are collections of constants and undefined mehtods which have to be defined by the classes implementing these interfaces.

Interfaces can create references to classes that implement them but cannot be instantiated themselves.

Interfaces are declared by the Interface similar to how we declare a class.

Inheriting is restricted to one base class while a class can implement any number of interfaces, allowing many unrelated classes to share wide variety of functionality

## Extensions
Extension methods allow adding to the functionality of a type without deriving a new one or modifying the existing one. 

Extension methods are placed in non-generic, static class. static and extension methods have a major differernce that extension methods uses this keyword when working on members.
## namespace
Namespaces are conatiner for classes used to prevent naming conflicts between classes and define boundaries for access methods on class members.

We can refer to all the contents of a namespace in our code by using the ' using ' keyword
```c#
using UnityEngine;
```

To decalre a namespace for our class we can enclose it using the namespace keyword
```c#
namespace Sample
{
    public class Demo : MonoBehaviour
    {
        //Some code
    }

    //Other classes
}
```

We can also access namespace code using dot operator, but it is a bit cumbersome
```c#
//Access Demo class of namespace Sample
Sample.Demo demo = new Sample.Demo();
```

Two Namespaces can have same methods which leads to ambiguity. To reslove this we should use namespace
```c#
//Both UnityEngine and System namespaces have Random method. To resolve conflict specify which one is used
UnityEngine.Random
//or
System.Random
```

## Lists
They are dynamically sized arrays with added functionality. Elements can be deleted, modified and added anytime after initialisation. They are generic

We can easily loop through, remove element and find one and access an element through index
## Dictionaries 
These are collection of key value pairs defined by { } braces and the Dictionary keyword.
## Coroutines
They are functions executed in intervals. It is basically a function called inside another function. THe differernce being that in front of all return statements we place keyword ' yield' to signify that the coroutine has given up execution priority to the immediate outside block from where it was called.

On yeidling a null IEnumerator the coroutine will yield execution and wait for the next update.

Coroutines return an IEnumerator value. They are started by 
> StartCoroutine( CoroutineCall ( ... ) );

## Quaternion
Quaternion are used to represent to reperesent Transform rotation. They are similar to vectors and have 4 components: (x, y, z, w)

Never adjust these components individually

Unity has provided Eulaer angles to handle rotations by Quaternion. Euler angles work on the rotation angles of axis. For this purpose al Quaternions are first converted to Euler angles and then represented in the inspector for use.

The reason for stil using Quaternion is Gimble law which poses problems during incremental rotations. This is not present in the case of Quaternions.

Example script : Rotation of one object relative to other pbject's movement. 

This can be achieved by using either the LookAt or Slerp function. 
1. LookRotation function takes the position vector and returns a relative Quaternion rotation to give the feel as if the object is being looked at
2. To make things appear more realistic the Slerp function which increasingly interpolate values of movement to rotation over time. It takes current local rotation of observer and the LookRotation Quaternion of Relative position vector and the time rate and returns a relative quaternion,giving a better, realisitic rotation approach.  

To set the rotation of a GameObject to Euler angle values (0,0,0) use Quaternion.Identity, to give 0 rotation about any axis.
```c#
transform.rotation = Quaternion.identity;
```