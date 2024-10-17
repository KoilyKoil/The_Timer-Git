using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveForce : MonoBehaviour
{
    public GameObject Player, FirePlug;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (FirePlug.GetComponent<ChangeAnim>().Done == false)
            {
                this.gameObject.AddComponent<Rigidbody2D>();
                Player.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10f, 0);
                FirePlug.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10f, 0);
            }
        }
    }
}
