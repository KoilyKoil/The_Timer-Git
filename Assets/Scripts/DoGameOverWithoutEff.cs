using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoGameOverWithoutEff : MonoBehaviour
{
    public GameObject gameoverpanel, player;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameoverpanel.SetActive(true);
        }
    }

    public void Replay()
    {
        player.GetComponent<Respond_Button_Pyer>().enabled = true;
    }
}
