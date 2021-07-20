using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform t1;
    public Transform t2;
    public (float, float) x = (-3f,3f);
    public (float, float) y = (-6f,5f);
    public Vector3 offset;

    public float smoothSpeed = 0.125f;
    void LateUpdate(){
        Vector3 targetPos = (t1.position + t2.position)/2 + offset;

        // if (targetPos.x < x.Item1) targetPos.x = x.Item1;
        // if (targetPos.x > x.Item2) targetPos.x = x.Item2;
        if (targetPos.y < y.Item1) targetPos.y = y.Item1;
        // if (targetPos.y > y.Item2) targetPos.y = y.Item2;
        transform.position = targetPos;
    }
}
