using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbalka : MonoBehaviour
{
    public int _s = 1;
    void Start()
    {
        
    }


    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            if (worldPosition.y + _s < -1f && worldPosition.y + _s > -4f)
            transform.position = new Vector3(transform.position.x, worldPosition.y + _s, 1f);
        }
        else if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touchPosition.y + _s < -1f && touchPosition.y + _s > -4f)
                transform.position = new Vector3(transform.position.x, touchPosition.y + _s, 1f);
        }
    }
}
