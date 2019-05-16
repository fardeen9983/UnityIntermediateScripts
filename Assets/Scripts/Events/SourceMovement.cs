using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceMovement : MonoBehaviour
{
    [Range(10,50)]
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current = transform.position;
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.Translate(0,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);
        if (current != transform.position) EventManager.execute( transform.position - current,transform);
    }
}
