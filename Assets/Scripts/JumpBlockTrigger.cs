using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlockTrigger : MonoBehaviour
{
    public GameObject Player;
    public float Jumpheight = 12f;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            Player.GetComponent<Rigidbody2D>().velocity = new Vector3(0, Jumpheight, 0);
        }
    }
}
