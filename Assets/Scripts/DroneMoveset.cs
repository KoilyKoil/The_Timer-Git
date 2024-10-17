using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMoveset : MonoBehaviour
{

    public GameObject Target;
    public FollowPlayer folpla;
    public Vector3 pos;     //현재 위치
    public Vector3 distance;        //드론과 대상의 거리차
    public float delta = 2f;   //좌우 이동 가능한 최댓값
    public float speed = 3f;        //현재 이동속도
    public float detect = 8f;           //인식범위

    public void Start()
    {
        folpla = GetComponent<FollowPlayer>();      //유도 스크립트를 불러옴
        pos = transform.position;           //pos=드론 벡터
    }

    public void Update()
    {
        distance = Target.transform.position - pos;     //distance=타겟과 드론의 차이
        if (Mathf.Abs(distance.x) > detect || Mathf.Abs(distance.y) > detect)       //대상이 범위 밖에 있을 때
        {
            Vector3 v = pos;
            v.y += delta * Mathf.Sin(Time.time * speed);        //좌우이동의 최대치 및 반전처리
            transform.position = v;     //이동
        }
        else                //범위 내에 대상이 들어오면
        {
            folpla.enabled = true;          //유도 활성화
            this.enabled = false;           //고정이동 비활성화
        }
    }
}
