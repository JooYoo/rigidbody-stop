using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubKinematic : MonoBehaviour
{
    private Rigidbody rb;
	void Start ()
	{
	    rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.AddForce(Vector3.forward);

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Pressed S");
            rb.isKinematic = true;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Pressed G");
            rb.isKinematic = false;
        }
    }
}
