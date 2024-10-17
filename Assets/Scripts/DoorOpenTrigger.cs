using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//버튼
public class DoorOpenTrigger : MonoBehaviour
{
    public GameObject Btn, OpnBtn;//, TargtDoor;
    public GameObject[] TargetDoor;
    //public static bool BtnActive = false;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {
            Btn.SetActive(false);   //기존 이미지 지워버림
            //BtnActive = true;
            for (int i = 0; i < TargetDoor.Length; i++)
            {
                TargetDoor[i].GetComponent<CompareButtonTrigger>().OpenDoor();
            }
            
            Instantiate(OpnBtn, transform.position, Quaternion.identity);       //버튼 애니메이션
        }
    }
}
