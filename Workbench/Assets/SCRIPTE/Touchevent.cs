using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touchevent : MonoBehaviour {
	int zug = 0;
	int punkte = 0;
	public Randomobject ro;
	public Text punktetext;
	public Text fehlertext;
	public Text overtext;
	

	
	void Start () {
				overtext.gameObject.SetActive(false);
	}
	

	     void Update(){
			 
       if (Input.GetMouseButtonDown(0)){ // if left button pressed...
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit)){
           //Debug.Log(hit.transform.gameObject);
		  
		  if(!(zug == 20)){
			  overtext.gameObject.SetActive(false);
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
		 if (zug >= 20){
		overtext.gameObject.SetActive(true);
		 if (hit.transform.gameObject.name == "bin_mesh"){
		zug = 0;
		punkte = 0;
		ro.Neuermull();
		overtext.gameObject.SetActive(false);
		 }}
	
		
		
		 
       }
	   punktetext.text = "Punkte: " + punkte;
	   fehlertext.text = "Fehler: " + zug;
	 
     }
	 
	 
	 
	 
		 }    
}

