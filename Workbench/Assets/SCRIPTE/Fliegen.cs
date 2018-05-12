using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliegen : MonoBehaviour {
	public float speed = 1;
	public float minHeight = 0;


	void Start () {
		
	}
	

	void Update () {
		transform.Translate (Camera.main.transform.forward * speed);

		if (transform.position.y < minHeight) transform.position = new Vector3(transform.position.x, minHeight, transform.position.z);
	}
}

