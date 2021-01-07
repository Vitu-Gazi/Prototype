using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject SecondTeleport;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = new Vector3(SecondTeleport.transform.position.x, SecondTeleport.transform.position.y, other.transform.position.z);
        }
    }
}
