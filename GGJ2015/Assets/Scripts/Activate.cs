using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Activate : MonoBehaviour {
	//Vector2 activeposition;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		//activeposition = this.transform.position;
       // Debug.Log("sent");
        GameObject.Find ("Player").SendMessage("Grapple",this.gameObject );
		//Debug.Log ("sent");

	}
}
