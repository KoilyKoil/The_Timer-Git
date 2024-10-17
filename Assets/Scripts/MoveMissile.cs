using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMissile : MonoBehaviour
{
    public float Speed=3f;

    public void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);
    }
}
