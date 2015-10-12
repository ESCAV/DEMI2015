using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {
    public GameObject efecto;

    private Transform target;

    void Awake()
    {
        target = transform.Find("target");
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject e = (GameObject)Instantiate(efecto, col.transform.position, col.transform.rotation);
        //Destroy(e, 1);
        col.transform.position = target.transform.position;
        col.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        e = (GameObject)Instantiate(efecto, col.transform.position, col.transform.rotation);
        //Destroy(e, 1);
    }
    void OnDrawGizmos()
     {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, target.position);

    }
}
