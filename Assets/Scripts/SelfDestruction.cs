using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    public GameObject Myself,Mine;

    public void Update()
    {
        if (Mine.GetComponent<ChangeAnim>().Done == true)
        {
            Invoke("SelfDestroy", 2f);
        }
    }

    public void SelfDestroy()
    {
        Destroy(GameObject.Find(Myself.name + "(Clone)"));
        Mine.SetActive(false);
    }
}
