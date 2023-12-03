using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame
    void Update()
    {
        float moveHorizontal =
            Input.GetAxis("Horizontal");

        // вправо и влево
        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
  
