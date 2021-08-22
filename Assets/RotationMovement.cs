using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMovement : MonoBehaviour
{
    public float RotationSpeed = 4;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
    }
}
