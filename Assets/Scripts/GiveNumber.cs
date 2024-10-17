using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveNumber : MonoBehaviour
{
    public int stagenumb;
    public GameObject savethis;
    public static GiveNumber instance;

    //중복 오브젝트 검사
    public void SearchExistance()
    {
        if (instance != null)
        {
            Destroy(GameObject.Find(this.name));
            SaveStageNumber();
        }

        instance = this;
        SaveStageNumber();
    }
    
    public void SaveStageNumber()
    {
        DontDestroyOnLoad(savethis);
    }
}
