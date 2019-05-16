using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Implement the interfaces
public class Avatar : MonoBehaviour, IKillable,IDamageale<int>
{
    public void Damage(int damageTaken)
    {
        //Any thing
    }

    public void Kill()
    {
        //Other code
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
