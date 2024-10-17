using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBullet : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 vec;

    public void Shoot()
    {
        vec=transform.position;
        vec.y += 0.01f;
        vec.x += 0.1f;
        Instantiate(bullet, vec, Quaternion.identity);
        vec.x -= -0.5f;
        Instantiate(bullet, vec, Quaternion.identity);
    }
}
