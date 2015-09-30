using UnityEngine;
using System.Collections;

public class CajaScript : MonoBehaviour {

    private float movex;
    private float movey;
    public float velocidad;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Pulsada X");
            Supercaja();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Pulsada z");
            Minicaja();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Izquierda");
            mover(-velocidad);
        }

        movex = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(movex * velocidad, 0);

    }

    void Supercaja()
    {
        this.transform.localScale = new Vector3(2, 2, 2);
        Debug.Log("SuperCaja");
    }

    void Minicaja()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
        Debug.Log("MiniCaja");
    }

    void mover(float vel)
    {
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(vel,0);

    }
}
