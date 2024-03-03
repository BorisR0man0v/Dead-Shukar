using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    public GameObject fish;


    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(gameObject);
        }
    }


    void OnCollisionEntwer2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Missile")
        {
            Destroy(gameObject, .5f);
        }
    }
}