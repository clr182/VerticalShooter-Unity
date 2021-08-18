using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform destination;

    private void Awake()
    {
        //destination = GetComponent<Transform>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("tele enter");
            collision.transform.position = destination.position;
        }
    }
}
