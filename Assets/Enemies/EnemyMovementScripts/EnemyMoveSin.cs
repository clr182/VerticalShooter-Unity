using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveSin : MonoBehaviour
{

    float sinCenterX;
    public float amplitude = 2;
    public float freq = 0.5f;

    public bool inverted = false;
    // Start is called before the first frame update
    void Start()
    {
        sinCenterX = transform.position.x;
    }



    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.y * freq) * amplitude;
        if(inverted)
        {
            sin *= -1;
        }
        pos.x = sinCenterX + sin;

        transform.position = pos;
    }
}
