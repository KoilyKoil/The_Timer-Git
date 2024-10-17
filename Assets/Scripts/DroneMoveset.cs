using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMoveset : MonoBehaviour
{

    public GameObject Target;
    public FollowPlayer folpla;
    public Vector3 pos;     //���� ��ġ
    public Vector3 distance;        //��а� ����� �Ÿ���
    public float delta = 2f;   //�¿� �̵� ������ �ִ�
    public float speed = 3f;        //���� �̵��ӵ�
    public float detect = 8f;           //�νĹ���

    public void Start()
    {
        folpla = GetComponent<FollowPlayer>();      //���� ��ũ��Ʈ�� �ҷ���
        pos = transform.position;           //pos=��� ����
    }

    public void Update()
    {
        distance = Target.transform.position - pos;     //distance=Ÿ�ٰ� ����� ����
        if (Mathf.Abs(distance.x) > detect || Mathf.Abs(distance.y) > detect)       //����� ���� �ۿ� ���� ��
        {
            Vector3 v = pos;
            v.y += delta * Mathf.Sin(Time.time * speed);        //�¿��̵��� �ִ�ġ �� ����ó��
            transform.position = v;     //�̵�
        }
        else                //���� ���� ����� ������
        {
            folpla.enabled = true;          //���� Ȱ��ȭ
            this.enabled = false;           //�����̵� ��Ȱ��ȭ
        }
    }
}
