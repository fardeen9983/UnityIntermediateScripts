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