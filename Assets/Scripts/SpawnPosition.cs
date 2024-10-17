using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    public GameObject player;
    public float px, py;

    public void Spawn()
    {
        player.transform.localPosition = new Vector3(px, py, 0f);
    }
}
