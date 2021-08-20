using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : MonoBehaviour
{
    public enum PickupObject{COIN};

    public PickupObject currentObject;
    public int pickupQuantity;
    public Player player;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(currentObject == PickupObject.COIN)
            {
                player.coins += pickupQuantity;
                Debug.Log("here");
            }
            Destroy(gameObject);
            
        }
    }

}
