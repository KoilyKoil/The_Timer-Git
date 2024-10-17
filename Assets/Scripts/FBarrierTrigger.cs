using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBarrierTrigger : MonoBehaviour
{
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.MyTime = 2f;
        }
    }
}
