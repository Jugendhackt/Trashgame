using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomobject : MonoBehaviour {
public List <GameObject> mulle;
public int mullsorte = 0;
	
	
	void Start () {
		Neuermull();
	}
	

	void Update () {
		if (mulle[0].activeSelf){
		mullsorte = 1;
		
		
		}
		if (mulle[1].activeSelf){
		mullsorte = 2;
		
		
		}
		if (mulle[2].activeSelf){
		mullsorte = 3;
		
		
		}
		if (mulle[3].activeSelf){
		mullsorte = 2;
		
		
		}
		//Debug.Log(mullsorte);
	}
	public void Neuermull(){
		for(int i = 0; i < mulle.Count;i++){
		mulle[i].SetActive(false);	
		}
		    
	mulle[Random.Range(0,mulle.Count)].SetActive(true);
		}
}
