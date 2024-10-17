using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePlayerPos : MonoBehaviour
{
    public float spx, spy;
    public GameObject sp;

    void Start()
    {
        sp.GetComponent<SpawnPosition>().px = spx;
        sp.GetComponent<SpawnPosition>().py = spy;
        sp.GetComponent<SpawnPosition>().Spawn();
    }
}
