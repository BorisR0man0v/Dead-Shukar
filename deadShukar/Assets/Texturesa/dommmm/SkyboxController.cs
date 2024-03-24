using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public class ColorName
{
    [UnityEngine.Header("Цвет неба")]
	[SerializeField]
	public Color Color;

	[UnityEngine.Header("Время")]
	[SerializeField]
    public float Time; //max 24
}

public class SkyboxController : MonoBehaviour
{
    public Camera Camera;

    public ColorName[] State;

    [Range(0,23.99f)]
    public float CurrentTime = 12;

    [Range(0,1)]
    public float SpeedTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        Camera = FindObjectOfType<Camera>();

        Current = Camera.backgroundColor;


		StartCoroutine(nameof(GetColor));
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime * SpeedTime;

        if(CurrentTime > 24)
        {
            CurrentTime = 0;
        }
	}

    private ColorName _colorName;
    private float _oldTime;
    private Color Current;

    private IEnumerator GetColor()
    {
        yield return new WaitForSeconds(0.25f);

		var state = State.OrderBy(x => x.Time).FirstOrDefault(x=>x.Time - CurrentTime > 0) ?? State.OrderBy(x=>x.Time).FirstOrDefault();

        if(_colorName == null || _colorName != state)
        {
            _colorName = state;
            _oldTime = CurrentTime;
            Current = Camera.backgroundColor;
		}

        var t = _colorName.Time - CurrentTime;
        if(t < 0)
        { 
            t = 24 + t;
        }
        var t2 = _colorName.Time - _oldTime;
		if(t2 < 0)
		{
			t2 = 24 + t2;
		}

		var deltaT = (t) / (t2);

        Camera.backgroundColor = deltaT * Current + (1 - deltaT) * _colorName.Color;

		StartCoroutine(nameof(GetColor));
    }
}
