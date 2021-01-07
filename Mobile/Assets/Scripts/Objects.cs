using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    [SerializeField]
    Vector3 startPos, lastPos, lastSpeed;
    Rigidbody rb;
    [SerializeField]
    bool x, y;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        lastSpeed = Vector3.zero;
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            lastPos = Input.mousePosition;
        }
        if (x)
        {
            if (lastPos.x > startPos.x + 250)
            {
                rb.velocity = new Vector3(2, 0);
                lastSpeed = rb.velocity;
            }
            else if (lastPos.x < startPos.x - 250)
            {
                rb.velocity = new Vector3(-2, 0);
                lastSpeed = rb.velocity;
            }
            else
            {
                rb.velocity = lastSpeed;
            }
        }
        if (y)
        {
            if (lastPos.y > startPos.y + 250)
            {
                rb.velocity = new Vector3(0, 2);
                lastSpeed = rb.velocity;
            }
            else if (lastPos.y < startPos.y - 250)
            {
                rb.velocity = new Vector3(0, -2);
                lastSpeed = rb.velocity;
            }
            else
            {
                rb.velocity = lastSpeed;
            }
        }
        
    }
}
