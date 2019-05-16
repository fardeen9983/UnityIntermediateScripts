using System.Collections;
using System.Collections.Generic;

public interface IKillable
{
    //Any class implementing this interface will have to necessarily define this method
    void Kill();
}

//An interface with generic data type will work with any type of data
public interface IDamageale<T>
{
    //The Type has to defined upon implementing the interface and should be used as same throughout the script
    void Damage(T damageTaken);
}
