using UnityEngine;
using System.Collections;

public class EnemyIA : MonoBehaviour {
    public enum Estado {parado, andando, persiguiendo }

    public Estado estado;
    // Use this for initialization
    void Start () {
        estado = Estado.parado;
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
