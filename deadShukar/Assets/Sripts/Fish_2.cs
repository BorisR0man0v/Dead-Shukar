using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Fish_2 : MonoBehaviour
{
    public GameObject _fish;
    void Start()
    {
       StartCoroutine(createFish());
    }


    void Update()
    {
        
    }
    private IEnumerator createFish()
    {
        yield return new WaitForSeconds(Random.Range(1f, 4f));
        GameObject fish = Instantiate(_fish);

        bool rightFish = Random.Range(0, 2) == 0;

        float y = Random.Range(-4.59f, 0f);
        float x;
         if (rightFish)
        {
            x = -8;
            fish.GetComponent<Fish_beginning> ().movement.x = -0.4f;
            fish.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
        else
        {
            x = -8;
            fish.GetComponent<Fish_beginning>().movement.x = 0.4f;

        }
        fish.GetComponent<Transform>().position =new Vector3(x,y,1);
        StartCoroutine(createFish());
    }

}
