using System;
using System.IO;
using UnityEngine;

public sealed class Test : MonoBehaviour
{
    private void Start()
    {
        using (StreamReader reader = new StreamReader("exemple path"))
        {
                
        }
    }
}