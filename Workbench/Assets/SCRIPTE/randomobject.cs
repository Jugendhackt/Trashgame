using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomobject : MonoBehaviour {
public List <GameObject> mulle;
	
	
	// Use this for initialization
	void Start () {
		for(int i = 0; i < mulle.Count;i++){
		mulle[i].SetActive(false);	
			
		}
		    
			Debug.Log(Random.Range(-10, 10));
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
