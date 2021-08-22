using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControls : MonoBehaviour
{
    Rigidbody2D rb;
    Player player;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * player.getSpeed(), 0));


    }

    private void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey("a"))
        {
            pos.x -= player.getSpeed() * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += player.getSpeed() * Time.deltaTime;
        }

        transform.position = pos;
    }

}
