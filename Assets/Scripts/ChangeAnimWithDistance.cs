using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimWithDistance : MonoBehaviour
{
    public GameObject Anim1, Anim2, Target;
    public bool Done = false;
    public Vector3 SaveX;
    public Vector3 TargetPos;
    public float distance = 5f;
    public float disapT = 0.4f;

    public void Start()
    {
        SaveX = transform.position;
    }

    public void Update()
    {
        TargetPos = Target.transform.position;
        if (Mathf.Abs(SaveX.x-TargetPos.x) < distance)
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
