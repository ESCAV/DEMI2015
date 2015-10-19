using UnityEngine;
using System.Collections;

public class coins : MonoBehaviour {
    public int puntos;
    GameControl gc;

    void Awake()
    {
        gc = GameObject.Find("GameControl").GetComponent<GameControl>();
    
    }
   
	void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Player"){
            gc.cambiaPuntos(puntos);
            Destroy(gameObject);

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {
            gc.cambiaPuntos(puntos);
            Destroy(gameObject);

        }
    }
}
