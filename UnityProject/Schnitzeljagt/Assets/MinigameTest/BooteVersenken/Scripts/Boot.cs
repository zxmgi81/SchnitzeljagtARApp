using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot : MonoBehaviour {


    public float MoveSpeed;


	// Use this for initialization
	void Start () {
        Destroy(gameObject, 30);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.right * Time.deltaTime * MoveSpeed;
	}

    private void OnTriggerEnter(Collider other)
    {
        // print(other.tag);
        if (other.CompareTag("Rock"))
        {
            Destroy(gameObject);
        }
    }
}
