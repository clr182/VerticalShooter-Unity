using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDrops : MonoBehaviour
{
    public List<GameObject> items;
    public int[] table =
    {
        80, // NULL
        20  // COIN
    };

    public int total;
    public int randomNumber;

    private void Start()
    {
        EventManager.current.EnemyDieEvent += dropCoin;
    }

    void dropCoin(Transform EnemyTransform)
    {
        Debug.Log("dropCoin Called");
        foreach (int item in table)
        {
            total += item;
        }

        randomNumber = Random.Range(0, total);


        for (int i = 0; i < table.Length; i++)
        {
            if (randomNumber <= table[i])
            {
                Instantiate(items[i], EnemyTransform.position, Quaternion.identity);
            }
            else
            {
                randomNumber -= table[i];
            }
        }
    }


    private void OnDisable()
    {
        EventManager.current.EnemyDieEvent -= dropCoin;
    }
}
