using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneWithLevel : MonoBehaviour
{
    public string wanttoload;
    public GameObject loadmanager;
    public void Update()
    {
        loadmanager.SetActive(true);
        LoadingScript.LoadScene(wanttoload);
    }
}
