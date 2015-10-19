using UnityEngine;
using System.Collections;

public class bomba : MonoBehaviour {
    GameControl gc;

    void Awake()
    {
        gc = GameObject.Find("GameControl").GetComponent<GameControl>();

    }
    void OnCollisionEnter2d(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {

            gc.restart();
        }
    }
}
