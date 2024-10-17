using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respond_Button_Pyer : MonoBehaviour
{
    //�̵� ������ ���� update ���

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

    //���� ������. ������ ��ư ������ �ʿ�����Ƿ� ������ �޼ҵ�� �и�
    public float jump = 8f;
    public bool JumpCount = false;

    public void Make_Jump()
    {
        if (JumpCount == false)
        {
            //Rigidbody2D�� �ڵ带 �ҷ�����, �ű⼭ �ش� ���͸� ��ȭ��Ŵ
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

    //�ð����� ������. ���������� ���Ϲ�ư���� ���۰���
    
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

    //�̵� �Է� Ȯ�ο�
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
