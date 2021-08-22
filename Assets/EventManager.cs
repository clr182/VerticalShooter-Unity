using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager current;
    public event Action<Transform> EnemyDieEvent;


    private void Awake()
    {
        if(current == null)
        {
            current = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }



    public void DropCoinEvent(Transform enemyTransform)
    {
        EnemyDieEvent?.Invoke(enemyTransform);
    }
}
