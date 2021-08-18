using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int dir = 1;
    public float bulletSpeed;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        
    }

    public void ChangeDirection()
    {
        dir *= -1;
    }
    
    void Update()
    {
        rb.velocity = new Vector2(0, bulletSpeed*dir);

        if (transform.position.y > 9)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dir == 1)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(gameObject);
                collision.gameObject.GetComponent<Enemy>().Damage();
            }
        }
        else if(dir == -1)
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                collision.gameObject.GetComponent<Player>().Damage();
            }
        }
    }
}
