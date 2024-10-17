using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearHiddenSpike : MonoBehaviour
{
    public GameObject Target;
    public Vector3 SaveX;
    public Vector3 TargetPos;
    public float distance = 5f;
    public HiddenSpikeTrigger hdnspk;

    // Start is called before the first frame update
    void Start()
    {
        SaveX = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        TargetPos = Target.transform.position;
        if (Mathf.Abs(SaveX.x - TargetPos.x) < distance)
        {
            hdnspk.GetComponent<HiddenSpikeTrigger>().enabled = true;
        }
    }
}
