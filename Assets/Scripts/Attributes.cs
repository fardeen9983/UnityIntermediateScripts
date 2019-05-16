using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//To execute the script even in edit mode
[ExecuteInEditMode]
public class Attributes : MonoBehaviour
{

    //Rotate the GameObject with given speed
    //To limit possible values of speed use attribute
    [Range(10,100)]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
}
