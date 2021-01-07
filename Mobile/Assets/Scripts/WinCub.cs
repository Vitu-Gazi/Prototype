using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCub : MonoBehaviour
{
    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 1, 0);
    }
}
