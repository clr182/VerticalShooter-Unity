using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject firePoint_left, firePoint_middle, firePoint_right, bullet;

    [SerializeField]
    private float speed;

    private int health = 3;
    private int delay = 0;
    public int delayTime = 30;
    public bool canShootLeft, canShootMiddle, canShootRight;

    private void Awake()
    {
        
        
        firePoint_left = transform.Find("Gun_Left").gameObject;
        firePoint_middle = transform.Find("Gun_Middle").gameObject;
        firePoint_right = transform.Find("Gun_Right").gameObject;
        
    }

    private void Update()
    {
        if(delay > delayTime)
        {
            Shoot();
        }
        delay++;
    }

    #region METHODS
    public void Shoot()
    {
        delay = 0;
        if (canShootLeft)
        {
            Instantiate(bullet, firePoint_left.transform.position, Quaternion.identity);
        }
        if (canShootMiddle)
        {
            Instantiate(bullet, firePoint_middle.transform.position, Quaternion.identity);
        }
        if (canShootRight)
        {
            Instantiate(bullet, firePoint_right.transform.position, Quaternion.identity);
        }
        //Instantiate(bullet, firePoint_left.transform.position, Quaternion.identity);
        //Instantiate(bullet, firePoint_middle.transform.position, Quaternion.identity);
        //Instantiate(bullet, firePoint_right.transform.position, Quaternion.identity);
    }

    public void Damage()
    {
        health--;
        StartCoroutine(Blink());
        if (health == 0)
            Destroy(gameObject);

    }


    IEnumerator Blink()
    {
        GetComponentInChildren<SpriteRenderer>().color = new Color(1, 0, 0);
        yield return new WaitForSeconds(0.2f);
        GetComponentInChildren<SpriteRenderer>().color = new Color(1, 1, 1);
    }


    #endregion

    #region GET/SET
    public int getDelay()
    {
        return delay;
    }

    public void setDelay(int newDelay)
    {
        delay = newDelay;
    }

    public int getDelayTime()
    {
        return delayTime;
    }

    public void setDelayTime(int newDelay)
    {
        delayTime = newDelay;
    }

    public float getSpeed()
    {
        return speed;
    }

    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public float getHealth()
    {
        return health;
    }

    public void setHealth(int newHealth)
    {
        health = newHealth;
    }
    #endregion
}   
