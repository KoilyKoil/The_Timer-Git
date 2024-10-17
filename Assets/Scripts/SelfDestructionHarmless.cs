using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructionHarmless : MonoBehaviour
{
    public GameObject Myself,Block;
    //public BreakBlock BB;

    public void Update()
    {
        if (Block.GetComponent<BreakBlock>().DoneB == true)
        {
            Invoke("SelfDestroy", 2f);
        }
    }

    public void SelfDestroy()
    {
        Destroy(GameObject.Find(Myself.name + "(Clone)"));
        Destroy(Block);
    }
}
