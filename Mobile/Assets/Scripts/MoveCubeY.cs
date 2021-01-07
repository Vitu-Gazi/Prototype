using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeY : MonoBehaviour
{
    public bool One;


    public Vector3 LastPos;
    public Vector3 Speed, StartPos;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (transform.position.y <= StartPos.y)
        {
            One = true;
        }
        else if (transform.position.y >= LastPos.y)
        {
            One = false;
        }
        if (One)
        {
            rb.velocity = Speed;
        }
        else
        {
            rb.velocity = -Speed;
        }
    }
}
