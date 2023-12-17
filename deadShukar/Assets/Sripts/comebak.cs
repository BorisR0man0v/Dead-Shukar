using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class BioatController : MonoBehaviour
{
    public SpriteRenderer
        spriteRenderer;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {

            FlipBoat(false);

        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            FlipBoat(true);
    }
        }
    void FlipBoat(bool facingRight)
    {
        if (facingRight)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }

    }
}