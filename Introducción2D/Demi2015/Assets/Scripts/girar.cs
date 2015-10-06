using UnityEngine;
using System.Collections;

public class girar : MonoBehaviour {
    public GameObject origen;
    public float velocidad = 5f;
    public float velocidad_giro = 5f;
    public float distancia = 2f;

    public bool girando = false;
    public bool lanzando = false;
    bool ida = true;
    Vector3 posicion_final;
    Vector3 posicion_inicial;
    // Use this for initialization
    void Start () {
        posicion_final = transform.position + (transform.position - origen.transform.position).normalized * 2;
        posicion_inicial = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
       
        if (girando)
        {
            transform.RotateAround(origen.transform.position, new Vector3(0, 0, 1), velocidad_giro);
        }
        if (lanzando)
        {
            if (ida) { 
             transform.position = Vector3.MoveTowards(transform.position, posicion_final, velocidad * Time.deltaTime);
                if (transform.position == posicion_final)
                {
                    ida = false;
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, posicion_inicial, velocidad * Time.deltaTime);
                if (transform.position == posicion_inicial)
                {
                    lanzando = false;
                    girando = true;
                }
            }
            // transform.position = Vector2.Lerp(transform.position, posicion_final, velocidad * Time.deltaTime);
            /*
            if (Vector3.Distance(transform.position, posicion_inicial) < distancia && ida)
            {
                transform.Translate(Vector3.right * velocidad * 2 * Time.deltaTime);
            }
            else
            {
                ida = false;
                transform.Translate(Vector3.left * velocidad * 2 * Time.deltaTime);
            }
            
            
           
             if (transform.position == posicion_inicial)
            {
                lanzando = false;
            }*/
        }



        if (Input.GetKeyDown(KeyCode.Space) && !lanzando)
        {
            posicion_final = transform.position + (transform.position - origen.transform.position).normalized * distancia;
            posicion_inicial = transform.position;
            lanzando = true;
            girando = false;
            ida = true;

        }
        Vector3 forward = transform.TransformDirection(Vector3.right) * distancia;
        //Debug.DrawRay(transform.position, forward, Color.green);
        Vector3 myRay = (transform.position - origen.transform.position).normalized ;
        Debug.DrawRay(transform.position, myRay, Color.green);
        

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(posicion_final, 0.1f);
    }
}
