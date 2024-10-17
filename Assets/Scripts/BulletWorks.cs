using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWorks : MonoBehaviour
{
    public MoveMissile SetSpeed;
    public SpriteRenderer sprend;
    public int HitCount = 0;
    public int limit = 2;

    public void Start()
    {
        SetSpeed.GetComponent<MoveMissile>();
        sprend.GetComponent<SpriteRenderer>();
        //HitCount = 0;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            if (HitCount < limit)
            {
                HitCount++;
                if (SetSpeed.Speed < 0f)
                {
                    sprend.flipX = false;
                }
                else if (SetSpeed.Speed > 0f)
                {
                    sprend.flipX = true;
                }
                SetSpeed.Speed *= -1;
            }
            else if (HitCount >= limit)
            {
                Destroy(GameObject.Find(this.name + "(Clone)"));
                Destroy(gameObject);
            }
        }
    }
}
