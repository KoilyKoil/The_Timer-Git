using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBarrierTrigger : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            DataManager.MyTime = 0.5f;
        }
    }
}
