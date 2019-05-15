# UnityIntermediateScripts
### Property : 
Benefit of using Properties instead of private properties is that 
1. Through combinations of getter and setter we can create either read-only, write-only or both types of properties.
2. Getters and setter can have other lines of code opening up to using coroutines.
### Ternary Operators
Acts on three operands.
1. A condition
2. The set of statements to execute if the condition is true
3. The set of statements to execute if the condition is false

Example:
```c#
int clip = 10;
string msg = clip > 0 ? "Clip ready" : "Reload!!";
