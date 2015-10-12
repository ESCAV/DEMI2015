using UnityEngine;
using System.Collections;
// The GameObject requires a Rigidbody component
[RequireComponent(typeof(Transform))]
public class mirar : MonoBehaviour {
    public Transform target;
    private Vector3 v_diff;
    private float atan2;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        v_diff = (target.position - transform.position);
        atan2 = Mathf.Atan2(v_diff.y, v_diff.x);
        transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg);
        Debug.Log(transform.localRotation.eulerAngles.z);
        if(transform.localRotation.eulerAngles.z > 90 && transform.localRotation.eulerAngles.z < 280)
        {
            transform.localScale = new Vector3(-1,-1,1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
