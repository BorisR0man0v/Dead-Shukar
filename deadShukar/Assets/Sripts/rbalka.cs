using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbalka : MonoBehaviour
{
    public int _s = 0;
    void Start()
    {
        
    }


    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            if (worldPosition.y + _s < 0.4f && worldPosition.y + _s > 0)
            transform.position = new Vector3(transform.position.x, worldPosition.y + _s, 1);
        }
        else if (Input.touchCount > 0)
        {
            Vector2 touch = Input.mousePosition;
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch);

            if (touchPosition.y + _s < 0.4f && touchPosition.y + _s > 0)
                transform.position = new Vector3(transform.position.x, touchPosition.y + _s, 1);
        }
    }
}
