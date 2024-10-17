using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperateStage : MonoBehaviour
{
    public GameObject gm;

    public void Start()
    {
        gm.GetComponent<GameManager>().OperateStageOnce();
        Destroy(this);
    }
}
