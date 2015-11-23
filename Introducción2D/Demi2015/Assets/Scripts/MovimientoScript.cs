using UnityEngine;
using System.Collections;

public class MovimientoScript : MonoBehaviour {
    public float moveSpeed = 200f;
    public float turnSpeed = 1000f;
    public float jumpForce = 100f;
    private Vector3 lookRight;
    private Vector3 lookLeft;
    // Use this for initialization
    void Start () {
        lookRight = transform.localScale;
        lookLeft = new Vector3(-lookRight.x,lookRight.y,lookRight.z);
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector2 velocidad = GetComponent<Rigidbody2D>().velocity;
        if (h != 0) { 
            GetComponent<Rigidbody2D>().velocity = new Vector2(h*moveSpeed, GetComponent<Rigidbody2D>().velocity.y);


            transform.localScale = (velocidad.x < 0) ?  lookLeft : lookRight;
           
        }
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }

       /* if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-jumpForce));
            
        }*/
        Debug.DrawLine(transform.position, new Vector3(transform.position.x + velocidad.x, transform.position.y + velocidad.y, transform.position.z),Color.green);
        Debug.DrawLine(transform.position, new Vector3(transform.position.x + h, transform.position.y + v, transform.position.z), Color.red);
    }
}
