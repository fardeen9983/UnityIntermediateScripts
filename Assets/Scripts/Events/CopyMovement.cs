using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMovement : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.onMove += copyMove;
    }
    private void OnDisable()
    {
        EventManager.onMove -= copyMove;
    }
   
    void copyMove(Vector3 diff,Transform source)
    {
        Vector3 current = transform.position;
        Debug.Log("copy :" + current);
        Debug.Log("orig" + diff);
        transform.Translate(current.x + diff.x, current.y + diff.y, current.z + diff.z);
        transform.rotation = source.rotation;
    }
}
