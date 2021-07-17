using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Vertical_moving_platform : MonoBehaviour
{
    // OffsetDown is negative
    // OffsetUp is positive

    [SerializeField] float offsetDown = 0, offsetUp = 0, speed = 1;
    [SerializeField] bool hasReachedUp= false, hasReachedDown = false;
    Vector3 startPosition = Vector3.zero;

    void Awake()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hasReachedUp)
        {
            if (transform.position.y < startPosition.y + offsetUp)
            {
                Move(offsetUp);
            }
            else if (transform.position.y >= startPosition.y + offsetUp)
            {
                hasReachedUp = true;
                hasReachedDown = false;
            }
        }
        else if (!hasReachedDown)
        {
            if (transform.position.y > startPosition.y + offsetDown)
            {
                Move(offsetDown);
            }
            else if (transform.position.y <= startPosition.y + offsetDown)
            {
                Console.WriteLine("Fuck");
                hasReachedUp = false;
                hasReachedDown = true;
            }
        }
    }

    void Move(float offset)
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                             new Vector3(transform.position.x,
                                                         startPosition.y + offset,
                                                         transform.position.z),
                                             speed * Time.deltaTime);
    }
}
