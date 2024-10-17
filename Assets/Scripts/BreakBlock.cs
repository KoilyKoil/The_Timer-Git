using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{
    public GameObject Explosion;
    public bool DoneB = false;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Bullet") == 0)
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            DoneB = true;
        }
    }
}
