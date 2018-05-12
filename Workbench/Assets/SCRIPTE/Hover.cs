using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {

    public float abstand = 0.5f;
    public float speed = 1f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start () {
        posOffset = transform.position;
	}
	
	void Update () {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * speed) * abstand;
        transform.position = tempPos;
    }
}
