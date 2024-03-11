using System.Collections;
using UnityEngine;

public class Fish_2 : MonoBehaviour
{
    public GameObject _fish;

    public float Ymin = 8;
    public float Ymax = 3;

    public float Xmean = 15;

    [SerializeField]
    private Transform _player;

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

        float y = Random.Range(_player.transform.position.y + Ymin, _player.transform.position.y + Ymax);
        float x;
         if (rightFish)
        {
            x = _player.transform.position.x + Xmean;
            fish.GetComponent<Fish_beginning> ().movement.x = -0.4f;
            fish.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
        else
        {
            x = _player.transform.position.x - Xmean;
            fish.GetComponent<Fish_beginning>().movement.x = 0.4f;
        }
        fish.GetComponent<Transform>().position =new Vector3(x,y,1);
        StartCoroutine(createFish());
    }

#if UNITY_EDITOR

	void OnDrawGizmos()
	{
		// Draw a yellow sphere at the transform's position
		Gizmos.color = new Color(0.5f, 0.5f, 0, 0.5f);

        if(_player != null)
        {
            Gizmos.DrawWireCube(new Vector3(_player.transform.position.x, _player.transform.position.y + (Ymin + Ymax) / 2), new Vector3(Xmean * 2, Ymin - Ymax));
        }
        else
        {
            Gizmos.color = Color.red;

			Gizmos.DrawLine(transform.position + new Vector3(-1, -1), transform.position + new Vector3(1,1));
            Gizmos.DrawLine(transform.position + new Vector3(1, -1), transform.position + new Vector3(-1,1));
		}
	}

#endif

}
