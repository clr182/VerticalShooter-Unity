using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBox : MonoBehaviour
{
    public float leftRightSpeed;
    public float increaseSpeed;
    bool goRight = true;
    Vector3 dropAmount = new Vector3(0, -1, 0);
    float boundryL = -4f;
    float boundryR = 4f;


    void Start()
    {
        transform.position = new Vector3(-3.9f, 5f, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if((transform.position.x >= boundryR) || (transform.position.x <= boundryL))
        {
            goRight = !goRight;
            DropALevel();
            leftRightSpeed += increaseSpeed;
        }
        Move(goRight);
    }

    private void Move(bool moveRight)
    {
        float moveX = moveRight ? leftRightSpeed : -leftRightSpeed;
        transform.Translate(new Vector3(moveX * Time.fixedDeltaTime, 0, 0));
    }

    private void DropALevel()
    {
        transform.Translate(dropAmount);
    }
}
