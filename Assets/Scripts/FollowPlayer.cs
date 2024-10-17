using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed;

    GameObject targetObject;            //��ǥ��
    Rigidbody2D rbody;

    public void Start()
    {
        //��ǥ�� ����
        targetObject = GameObject.Find("Player");
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;         //�߷� 0���� ����
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;          //Z�� ȸ�� ����
    }

    public void FixedUpdate()
    {
        //������ Ÿ�� ������Ʈ ���� ���ϱ�
        //��ǥ�� ����- �� ������Ʈ�� ���͸� ���� ��, �������� ������ ������ ���̴� 1�� ���� ����
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

        //���� �ӵ� ����
        float vx = dir.x * speed;
        float vy = dir.y * speed;

        //�ش� ���������� �ӵ� ����
        rbody.velocity = new Vector2(vx, vy);

        //x���� �ѱ�� ����
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }

}
