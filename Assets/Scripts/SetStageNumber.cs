using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStageNumber : MonoBehaviour
{
    public int insertnumber;
    public GiveNumber givnum;

    public void SetNumber()
    {
        givnum.stagenumb = insertnumber;
    }

    public void ClearNumber()
    {
        givnum.stagenumb = 0;
    }
}
