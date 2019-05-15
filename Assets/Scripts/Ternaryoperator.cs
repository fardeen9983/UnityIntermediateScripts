using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ternaryoperator : MonoBehaviour
{
    private int clip;
    // Start is called before the first frame update
    void Start()
    {
        clip = Random.Range(10, 101);
    }

    // Update is called once per frame
    void Update()
    {
        bool x = clip > 0 ? true : false;
        if (x)
            //Shoot
            clip--;
        else
            //Reload    
            clip = Random.Range(10, 101);

        Debug.Log("Clip : " + clip);
    }
}
