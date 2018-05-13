using UnityEngine;
using UnityEngine.VR;
using UnityEngine.UI;
using System.Collections;

public class Ansehen : MonoBehaviour {

	public GameObject Zielobjekt1;
	public GameObject Zielobjekt2;

	// Use this for initialization
	void Start () {

	}

	void Update (){

	}


	// Update is called once per frame
	void FixedUpdate () {
		RaycastHit hit;
		Vector3 forward = this.transform.TransformDirection(Vector3.forward) * 100;

		if (Physics.Raycast(this.transform.position, forward, out hit)){
			print(hit.collider.name);

			if (hit.collider.name == Zielobjekt1.name) {
				Zielobjekt1.SetActive(false);
				Zielobjekt2.SetActive(true);
			}

			if (hit.collider.name == Zielobjekt2.name) {
				Zielobjekt1.SetActive(true);
				Zielobjekt2.SetActive(false);
			}

        } else {

			//if (state != "clip" && gaze.color.a != .25f) gaze.color = new Color(1f, 1f, 1f, .25f);
        }
            
		Debug.DrawRay(this.transform.position, forward, Color.green);
	}

}
