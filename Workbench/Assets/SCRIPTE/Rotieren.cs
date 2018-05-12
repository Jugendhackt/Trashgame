using UnityEngine;
using System.Collections;

public class Rotieren : MonoBehaviour {

	public Vector3 Drehen;
	public float Geschwindigkeit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Drehen * Time.deltaTime * Geschwindigkeit, Space.World);
	}
}
