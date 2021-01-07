using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    Vector3 startPos, lastPos, lastSpeed;


    public string Name;
    Rigidbody rb; private void Start()
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
            else if (lastPos.y > startPos.y + 250)
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


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            PlayerPrefs.SetInt(Name, 2);
            Debug.Log("Create Key");
            SceneManager.LoadScene("MainMenu");
        }
    }
}
