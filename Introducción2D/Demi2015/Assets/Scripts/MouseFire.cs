using UnityEngine;
using System.Collections;

public class MouseFire : MonoBehaviour
{

    public GameObject fire;
    Vector3 targetPosition;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            p.z = 0;
            GameObject obj = (GameObject)Instantiate(fire, p, transform.rotation);
            Debug.Log(targetPosition);

        }
       

    }
}
