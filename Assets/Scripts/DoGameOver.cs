using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoGameOver : MonoBehaviour
{
    public GameObject Anim1, Anim2, gameoverpanel, player;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            gameoverpanel.SetActive(true);
            player.GetComponent<Respond_Button_Pyer>().enabled = false;
            Instantiate(Anim1, transform.position, Quaternion.identity);
            Invoke("ChangeAnim", 0.5f);
        }
    }

    public void ChangeAnim()
    {
        Destroy(gameObject);
        Instantiate(Anim2, transform.position, Quaternion.identity);
    }

    public void Replay()
    {
        player.GetComponent<Respond_Button_Pyer>().enabled = true;
    }
}
