using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gehen : MonoBehaviour {
	public float speed = 1;
	public float Height = 2;
	float tempspeed;


	void Start () {
		tempspeed = speed;
	}


	void Update () {
		transform.Translate (Camera.main.transform.forward * speed);
		transform.position = new Vector3(transform.position.x, Height, transform.position.z);

		//print (Camera.main.transform.localEulerAngles);

		if (Camera.main.transform.localEulerAngles.x > 80 && Camera.main.transform.localEulerAngles.x < 90) {
			speed = 0;
		} else { 
			if (Camera.main.transform.localEulerAngles.x < 280 && Camera.main.transform.localEulerAngles.x > 270) {
			speed = tempspeed;
		}
	}
 }
}
