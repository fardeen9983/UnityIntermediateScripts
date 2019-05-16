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

