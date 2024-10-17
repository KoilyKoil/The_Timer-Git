using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenSpikeTrigger : MonoBehaviour
{
    public float delta = 2f;   //상하 이동 가능한 최댓값
    public float revdelta = -2f;
    public float speed = 8f;        //현재 이동속도와 방향
    public float pos;
    public float flipcon = 0.2f;
    public float disapT = 0.5f;
    public GameObject Anim1, Anim2;

    void Start()
    {
        pos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
            //위에서 아래로 튀어오름
        pos += Time.deltaTime*speed;
        if (pos >= delta)
        {
            speed *= -1;
            pos = delta;
        }
        else if (pos <= revdelta)
        {
            speed *= -1;
            pos = revdelta;
        }
        transform.position = new Vector3(transform.position.x, pos, transform.position.z);     //이동

        Invoke("DaFlip", flipcon);          //일정 시간 이후에 반전
        Invoke("ChangeAnimation", disapT);
    }

    public void DaFlip()
    {
        this.GetComponent<SpriteRenderer>().flipY=(true);
    }

    public void ChangeAnimation()
    {
        //Destroy(GameObject.Find(Anim1.name + "(Clone)"));
        Destroy(Anim1);
        Instantiate(Anim2, transform.position, Quaternion.identity);
    }
}
