using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 

    float points = 0;
    float highscore;
    GameObject playerObject;



    private void Awake()
    {
        playerObject = GameObject.Find("Player");
    }

    private void Start()
    {
    }




    void SetHighScore()
    {
        if (points > highscore)
        {
            highscore = points;
        }
    }

    void EndGame()
    {
        if (playerObject.gameObject.GetComponent<Player>().getHealth() < 1)
        {

        }
    }

}
