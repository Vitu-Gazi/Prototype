using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeX : MonoBehaviour
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
        if (transform.position.x <= StartPos.x)
        {
            One = true;
        }
        else if (transform.position.x >= LastPos.x)
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
