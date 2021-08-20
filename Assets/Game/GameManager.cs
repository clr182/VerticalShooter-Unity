using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    [SerializeField] private Player player;
    [SerializeField] private Spawner spawner;


    private void Start()
    {
        player = new Player();
        spawner = new Spawner();
    }
}
