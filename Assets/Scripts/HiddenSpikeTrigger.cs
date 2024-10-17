using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenSpikeTrigger : MonoBehaviour
{
    public float delta = 2f;   //���� �̵� ������ �ִ�
    public float revdelta = -2f;
    public float speed = 8f;        //���� �̵��ӵ��� ����
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
            //������ �Ʒ��� Ƣ�����
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
        transform.position = new Vector3(transform.position.x, pos, transform.position.z);     //�̵�

        Invoke("DaFlip", flipcon);          //���� �ð� ���Ŀ� ����
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
