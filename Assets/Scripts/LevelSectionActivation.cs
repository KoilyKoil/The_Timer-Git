using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSectionActivation : MonoBehaviour
{
    public GameObject[] Sect;
    public int sectnumber=0;

    void DeActiveSect()
    {
        for (int i = 0; i < Sect.Length; i++)
        {
            Sect[i].SetActive(false);
        }
    }

    public void ActiveSect()
    {
        DeActiveSect();
        Sect[sectnumber].SetActive(true);
    }
}
