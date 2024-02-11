using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed = 1.0f;
    public float changeDirectioninterval = 1.0f;

    private float directionTimer;
    void Start()
    {
        directionTimer = changeDirectioninterval;

    }

    void Update()
    {
        directionTimer -= Time.deltaTime;
        if (directionTimer < 0)
        {
            directionTimer = changeDirectioninterval;
        }

        transform.Translate(Vector2.right *  speed * Time.deltaTime);
    }

    void ChangeDirection()
    {
        Vector2 newScale = transform.localScale;
        speed = -1;
        newScale.x = -13;
        transform.localScale = newScale;
    }

}
