using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respond_Button_Pyer : MonoBehaviour
{
    //이동 유지를 위해 update 사용

    public void Update()
    {
        if (StateofLeft == true)
        {
            transform.Translate(new Vector2(-10f * DataManager.MyTime * Time.deltaTime, 0));
        }
        else if (StateofRight == true)
        {
            transform.Translate(new Vector2(10f * DataManager.MyTime * Time.deltaTime, 0));
        }
    }

    //점프 구현용. 점프는 버튼 유지가 필요없으므로 임의의 메소드로 분리
    public float jump = 8f;
    public bool JumpCount = false;

    public void Make_Jump()
    {
        if (JumpCount == false)
        {
            //Rigidbody2D의 코드를 불러내고, 거기서 해당 벡터를 변화시킴
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
            JumpCount = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            JumpCount = false;
        }
    }

    //시간조작 구현용. 마찬가지로 단일버튼으로 조작가능
    
    private Rigidbody2D rigbod;

    public void SetFaster()
    {
        rigbod = GetComponent<Rigidbody2D>();
        if (DataManager.MyTime == 1f)
        {
            DataManager.MyTime = 2f;
            rigbod.gravityScale = 2.5f;
        }
        else
        {
            DataManager.MyTime = 1f;
            rigbod.gravityScale = 2f;
        }
    }

    public void SetSlower()
    {
        rigbod = GetComponent<Rigidbody2D>();
        if (DataManager.MyTime == 1f)
        {
            DataManager.MyTime = 0.5f;
            rigbod.gravityScale = 1.5f;
        }
        else
        {
            DataManager.MyTime = 1f;
            rigbod.gravityScale = 2f;
        }
    }

    //이동 입력 확인용
    public bool StateofLeft = false;
    public bool StateofRight = false;

    public void Move_Left()
    {
        StateofLeft = true;
    }

    public void Move_Right()
    {
        StateofRight = true;
    }

    public void Stop_Left()
    {
        StateofLeft = false;
    }

    public void Stop_Right()
    {
        StateofRight = false;
    }
}
