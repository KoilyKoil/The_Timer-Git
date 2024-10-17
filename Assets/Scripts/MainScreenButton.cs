using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenButton : MonoBehaviour
{
    public GameObject Screen1, Screen2, Screen3, lodScreen1, lodScreen2, lodScreen3, lodScreenH;

    public void DeActive()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        lodScreen1.SetActive(false);
        lodScreen2.SetActive(false);
        lodScreen3.SetActive(false);
        lodScreenH.SetActive(false);
    }

    public void ActiveScreen1()
    {
        DeActive();
        Screen1.SetActive(true);
    }

    public void ActiveScreen2()
    {
        DeActive();
        Screen2.SetActive(true);
    }

    public void ActiveScreen3()
    {
        DeActive();
        Screen3.SetActive(true);
    }

    public void ActivelodScreen1()
    {
        DeActive();
        lodScreen1.SetActive(true);
    }

    public void ActivelodScreen2()
    {
        DeActive();
        lodScreen2.SetActive(true);
    }

    public void ActivelodScreen3()
    {
        DeActive();
        lodScreen3.SetActive(true);
    }

    public void ActivelodScreenH()
    {
        DeActive();
        lodScreenH.SetActive(true);
    }
}
