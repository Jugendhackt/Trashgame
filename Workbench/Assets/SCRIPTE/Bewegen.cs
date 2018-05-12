using UnityEngine;
using System.Collections;

public class Bewegen : MonoBehaviour {
    public Vector3[] Ziele;
    public float speed = 1;
	float tempSpeed;
    int pos = 0;
	public int waitPos;
    public int zweitewaitPos;
    bool wait = false;
	public float Wartezeit = 5;
    public float zweiteWartezeit = 5;

    void Start()
	{
		tempSpeed = speed;
	}

    void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, Ziele[pos], step);

		Vector3 targetDir = Ziele[pos] - transform.position;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        transform.rotation = Quaternion.LookRotation(newDir);


		if (transform.position == Ziele[pos]) {
            if (pos < Ziele.Length - 1)
            {
                pos++;
                if (pos == waitPos)
                {
                    speed = 0;
                    Invoke("Wait", Wartezeit);
                }
            }
            else if (pos == zweitewaitPos)
            {
                speed = 0;
                Invoke("Wait", zweiteWartezeit);
            } else {
				pos = 0;
			}
		}
    }

	void Wait() {
			speed = tempSpeed;
	}
		
}