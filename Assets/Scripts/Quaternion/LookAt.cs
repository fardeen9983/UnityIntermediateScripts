using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation(sphere.transform.position - transform.position);
        Quaternion current = transform.localRotation;
        transform.rotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        //transform.rotation = rotation;
    }
}
