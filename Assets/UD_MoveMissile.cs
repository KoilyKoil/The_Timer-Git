using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_MoveMissile : MonoBehaviour
{
    public float Speed = 3f;

    public void Update()
    {
        transform.Translate(0, Speed * Time.deltaTime, 0);
    }
}
