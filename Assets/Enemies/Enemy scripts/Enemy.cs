using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float fireRate, health;
    public bool canShoot;
    public GameObject bullet, explosion, coin;
    public int score;



    void Start()
    {
        if (canShoot)
        {
            InvokeRepeating("Shoot", fireRate, fireRate);
        }
    }

    private void FixedUpdate()
    {
        if(gameObject.transform.position.y < -11f)
        {
            Die();
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().Damage();
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + score);
        Instantiate(explosion, transform.position, Quaternion.identity);
        Instantiate(coin, transform.position, Quaternion.identity);
    }

    public void Damage()
    {
        health--;
        if (health == 0)
            Die();
    }

    void Shoot()
    {
        GameObject temp = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
        temp.GetComponent<Bullet>().ChangeDirection();
    }



}
