using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliegenundgehen : MonoBehaviour {

	public float speedgehen = 1;
	public float speedfliegen = 1;
	public float Heightgehen = 2;
	public float minHeightfliegen = 0;
	public GameObject SwitchObjekt;
	float tempspeed;
	bool fliegen = false;


	void Start () {
		tempspeed = speedgehen;
		speedgehen = 0;
	}


	void Update () {
		if (fliegen == false) {
		transform.Translate (Camera.main.transform.forward * speedgehen);
			transform.position = new Vector3 (transform.position.x, Heightgehen, transform.position.z);

		//print (Camera.main.transform.localEulerAngles);

			if (Camera.main.transform.localEulerAngles.x > 80 && Camera.main.transform.localEulerAngles.x < 90) {
				speedgehen = 0;
			} else if (Camera.main.transform.localEulerAngles.x < 280 && Camera.main.transform.localEulerAngles.x > 270) {
					speedgehen = tempspeed;
				}
		} else {
			transform.Translate (Camera.main.transform.forward * speedfliegen);
			if (transform.position.y < minHeightfliegen) {
				transform.position = new Vector3 (transform.position.x, minHeightfliegen, transform.position.z);
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		

		if (other.gameObject.name == SwitchObjekt.name && fliegen == false) {
			fliegen = true;

		} else if (other.gameObject.name == SwitchObjekt.name && fliegen == true) {
			fliegen = false;

		}
	}
}
