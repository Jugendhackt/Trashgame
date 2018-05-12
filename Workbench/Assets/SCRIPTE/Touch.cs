using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {
    public GameObject Zielobjekt1;

    void Update() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
			if (Zielobjekt1.activeSelf == true) Zielobjekt1.SetActive(false);
			else Zielobjekt1.SetActive(true);
        }
    }
}