using UnityEngine;

public class turn : MonoBehaviour
{
    public GameObject fish;

    private void Start()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    Instantiate(gameObject);
        //}

        Destroy(gameObject, 15);
    }


    //private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Missile")
    //    {
    //        Destroy(gameObject, .5f);
    //    }
    //}
}