using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementZigZag : MonoBehaviour
{
    public float ySpeed;
    float moveRate = 1;
    Vector3 Destination;
    float xPos,yPos;
    float timer =1f;
    float timerSpeed;
    float timeToMove;

    // Start is called before the first frame update
    void Start()
    {
        xPos = Random.Range(-4.00f, 4.00f);
        yPos = Random.Range(5.00f, 0.00f);

        Destination = new Vector2(xPos, yPos);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * moveRate;
        if(timer >= timeToMove)
        {
            transform.position = Vector2.Lerp(transform.position, Destination, Time.deltaTime * ySpeed);
            if (Vector2.Distance(transform.position, Destination) <= 0.01f)
            {
                xPos = Random.Range(-4.00f, 4.00f);
                yPos = Random.Range(5.00f, 0.00f);
                Destination = new Vector2(xPos, yPos);
                timer = 0.0f;
            }
        }
    }


}
