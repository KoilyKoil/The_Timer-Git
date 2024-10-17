using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//¹®
public class CompareButtonTrigger : MonoBehaviour
{
    public GameObject Dor, OpnDor;

    public void OpenDoor()
    {
        //if (DoorOpenTrigger.BtnActive==true)
        //{
            Dor.SetActive(false);
            Instantiate(OpnDor, transform.position, Quaternion.identity);
            //DoorOpenTrigger.BtnActive = false;
        //}
    }
}
