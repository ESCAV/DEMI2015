using UnityEngine;
using System.Collections;

public class puente : MonoBehaviour {

    public float resistencia = 1;
    public float estres;

    private SpringJoint2D union;
    private float distancia;
    
	// Use this for initialization
	void Start () {
        union = GetComponent<SpringJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
        distancia = Vector3.Distance(union.connectedBody.transform.position, transform.position);
        estres = distancia / union.distance;
        Debug.Log(estres);
        if(estres > resistencia)
        {
            union.enabled = false;
        }
       
    }
}
