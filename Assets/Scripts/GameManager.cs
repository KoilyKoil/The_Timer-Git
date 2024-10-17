using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //스테이지 넘버를 받아옴
    int nowStage;
    GameObject StageManager;
    public GameObject[] opstg;

    void Start()
    {
        StageManager = GameObject.Find("GiveStageNumber");
        nowStage = StageManager.GetComponent<GiveNumber>().stagenumb;
    }

    
    //스테이지 최초로딩
    public GameObject panel1, panel2, sp;

    public void OperateStageOnce()
    {
        for (int i = 0; i < opstg.Length; i++)
        {
            opstg[i].SetActive(false);
        }

        opstg[nowStage].SetActive(true);
        sp.GetComponent<SpawnPosition>().Spawn();
        panel1.SetActive(false);
        panel2.SetActive(false);
    }
    

    //스테이지 로딩
    public GameObject loadscreen2;

    public void OperateStage()
    {
        panelcanvas.SetActive(false);
        mainscreen.SetActive(false);
        for (int i = 0; i < opstg.Length; i++)
        {
            opstg[i].SetActive(false);
        }
        loadscreen2.SetActive(true);
    }

    //로딩화면 활성화
    public GameObject loadscreen, mainscreen, panelcanvas;

    public void OperateLoadingScreen()
    {
        panelcanvas.SetActive(false);
        mainscreen.SetActive(false);
        for (int i = 0; i < opstg.Length; i++)
        {
            opstg[i].SetActive(false);
        }
        loadscreen.SetActive(true);
    }

    //다음 스테이지를 위한 값 변화
    public void UpStage()
    {
        StageManager.GetComponent<GiveNumber>().stagenumb++;
    }
}
