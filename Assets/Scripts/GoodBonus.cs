
using UnityEngine;

public class GoodBonus : InteractiveObject, IFlay, IFlicker
{
    private Material _material;
    private float _lengthFlay;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _lengthFlay = Random.Range(1.0f, 5.0f);
    }

    private void GetComponent<T>()
    {
        throw new System.NotImplementedException();
    }

    protected override void Interaction()
    {
        // Add bonus
    }

    public void Flay()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, 
            Mathf.PingPong(Time.time, _lengthFlay),
            transform.localPosition.z);
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
            Mathf.PingPong(Time.time, 1.0f));
    }
    
}


