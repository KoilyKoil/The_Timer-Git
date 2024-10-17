using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //�������� �ѹ��� �޾ƿ�
    int nowStage;
    GameObject StageManager;
    public GameObject[] opstg;

    void Start()
    {
        StageManager = GameObject.Find("GiveStageNumber");
        nowStage = StageManager.GetComponent<GiveNumber>().stagenumb;
    }

    
    //�������� ���ʷε�
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
    

    //�������� �ε�
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

    //�ε�ȭ�� Ȱ��ȭ
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

    //���� ���������� ���� �� ��ȭ
    public void UpStage()
    {
        StageManager.GetComponent<GiveNumber>().stagenumb++;
    }
}
