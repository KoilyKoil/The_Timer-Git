using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSectNumber : MonoBehaviour
{
    public LevelSectionActivation ForNumber;

    public void IncreaseSectNumber()
    {
        ForNumber = GetComponent<LevelSectionActivation>();

        if (ForNumber.sectnumber+1 >= 0 && ForNumber.sectnumber+1 <= 6)
        {
            ForNumber.sectnumber++;
        }
    }

    public void DecreaseSectNumber()
    {
        ForNumber = GetComponent<LevelSectionActivation>();

        if (ForNumber.sectnumber-1 >= 0 && ForNumber.sectnumber-1 <= 6)
        {
            ForNumber.sectnumber--;
        }
    }
}
