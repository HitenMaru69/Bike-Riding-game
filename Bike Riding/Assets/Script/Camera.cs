using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform bike;
    public Vector3 offset;
  

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 newpos = bike.position + offset;
        newpos.y = transform.position.y;
        transform.position = newpos;
    }
}
