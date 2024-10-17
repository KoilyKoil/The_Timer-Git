using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed;

    GameObject targetObject;            //목표물
    Rigidbody2D rbody;

    public void Start()
    {
        //목표물 설정
        targetObject = GameObject.Find("Player");
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;         //중력 0으로 설정
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;          //Z축 회전 막음
    }

    public void FixedUpdate()
    {
        //추적할 타겟 오브젝트 방향 구하기
        //목표물 벡터- 이 오브젝트의 벡터를 연산 후, 연산결과와 방향은 같지만 길이는 1인 벡터 생성
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

        //추적 속도 설정
        float vx = dir.x * speed;
        float vy = dir.y * speed;

        //해당 방향으로의 속도 세팅
        rbody.velocity = new Vector2(vx, vy);

        //x축을 넘기면 반전
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }

}
