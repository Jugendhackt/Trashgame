using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touchevent : MonoBehaviour {
	int zug = 0;
	int punkte = 0;
	public Randomobject ro;
	public Text punktetext;
	void Start () {
		
	}
	

	     void Update(){
			 if(!(zug == 20)){
       if (Input.GetMouseButtonDown(0)){ // if left button pressed...
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit)){
           //Debug.Log(hit.transform.gameObject);
		   
		   switch (hit.transform.gameObject.name){
		case("restmull"):
		if (ro.mullsorte == 3){
			ro.Neuermull();
			punkte +=10;
			}else{punkte -=5;
			zug++;}	
		break;
		case("gelbmull"):
		if (ro.mullsorte == 1){
			ro.Neuermull();
			punkte +=10;
			}else{punkte -=5;
			zug++;}	
		break;
		case("papiermull"):
		if (ro.mullsorte == 2){
			ro.Neuermull();
			punkte +=10;
			}else{punkte -=5;
			zug++;}	
		break;
		 }
         }
	
		
		
		 
       }
	   punktetext.text = "Punkte: " + punkte + ", Fehler: " + zug;
	 
     }
	 
	 
	 
		 }    
}

