using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x + Time.deltaTime , transform.position.y + Mathf.Sin(Time.time*10)/10, transform.position.z);
	}
}
