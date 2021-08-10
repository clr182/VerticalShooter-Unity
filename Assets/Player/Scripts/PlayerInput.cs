using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;
    Vector3 movement;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //if(Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        //    touchPosition.z = 0f;
        //    touchPosition.y = 0f;
        //    transform.position = touchPosition;
        //
        //    for(int i = 0; i <Input.touchCount; i++)
        //    {
        //        Camera.main.ScreenToWorldPoint(Input.touches[i].position);
        //        Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
        //    }
        //}
    }


    private void FixedUpdate()
    {
        transform.Translate(movement * Time.deltaTime * moveSpeed, Space.World);
    }
}
