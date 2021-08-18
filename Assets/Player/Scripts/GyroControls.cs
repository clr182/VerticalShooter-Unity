using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControls : MonoBehaviour
{
    Player player;
    Rigidbody2D rb;
    float dirX;


    private void Awake()
    {
        player = GetComponent<Player>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * player.getSpeed();
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -4.5f, 4.5f), transform.position.y);
        
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
