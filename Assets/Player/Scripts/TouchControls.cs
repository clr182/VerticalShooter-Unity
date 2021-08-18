using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{

    Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }


    void Update()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        touchPosition.z = 0;
        touchPosition.y = -8.26f;
        transform.position = touchPosition;

    }
}
