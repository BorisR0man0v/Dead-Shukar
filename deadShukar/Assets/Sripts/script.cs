using UnityEngine;

public class script : MonoBehaviour
{
    [SerializeField] SpriteRenderer _m;
    [SerializeField] private Color _c;
    public void setColor()
    {
        _m.color = Color.yellow;
    }
}
