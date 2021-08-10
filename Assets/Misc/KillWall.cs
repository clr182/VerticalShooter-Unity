using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillWall : MonoBehaviour
{





    private void OnTriggerEnter(Collider other)
    {
        Destroy(other);
    }
}
