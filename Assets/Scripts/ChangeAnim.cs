using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnim : MonoBehaviour
{
    public GameObject Anim1, Anim2;
    public bool Done = false;
    public Vector3 SaveX;
    public float disapT = 0.4f;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        SaveX = transform.position;
        if (collision.gameObject.tag == "Player")
        {
            if (Done == false)
            {
                Instantiate(Anim1, SaveX, Quaternion.identity);
                Invoke("ChangeAnimation", disapT);
            }
            Done = true;
        }
    }

    public void ChangeAnimation()
    {
        Destroy(GameObject.Find(Anim1.name + "(Clone)"));
        Instantiate(Anim2, SaveX, Quaternion.identity);
    }
}
