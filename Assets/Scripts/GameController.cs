﻿
using System; 
using UnityEngine;
using Object = UnityEngine.Object;

public sealed class GameController : MonoBehaviour, IDisposable
{
    private InteractiveObject[] _interactiveObjects;

    private void Awake()
    {
        _interactiveObjects = FindObjectsOfType<InteractiveObject>();
    }

    private void Update()
    {
        for (var i = 0; i < _interactiveObjects.Length; i++)
        {
            var interactiveObject = _interactiveObjects[i]; 
 
            if (interactiveObject == null)
            {
                continue;
            }

            if (interactiveObject is IFlay flay)
            {
                flay.Flay();
            }
            if (interactiveObject is IFlicker flicker)
            {
                flicker.Flicker();
            }
            if (interactiveObject is IRotation rotation)
            {
                rotation.Rotation();
            }
        }
    }
    public void Dispose()
    {
        foreach (var o in _interactiveObjects)
        {
            Destroy(o.gameObject);
        }
    }
    

}



internal interface IRotation
{
    void Rotation();
}

internal interface IFlicker
{
    void Flicker();
}

internal interface IFlay
{
    void Flay();
}

public class InteractiveObject
{
    public Object gameObject;

    protected virtual void Interaction()
    {
        
    }
}