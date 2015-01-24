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
		if (gameObject.GetComponent<SpringJoint2D> ().connectedBody != null){
			if (GameObject.Find("Player").transform.position.x >= (this.transform.position.x-.3) && GameObject.Find("Player").transform.position.x <= (this.transform.position.x+.3) ){
				gameObject.GetComponent<SpringJoint2D> ().connectedBody = null;	
			}
		}
	}

	void OnMouseDown(){
		Debug.Log(gameObject.GetComponent<SpringJoint2D> ().connectedBody);
		float dist = Vector2.Distance (GameObject.Find ("Player").transform.position, this.transform.position);
		if (dist <= 10f){
			gameObject.GetComponent<SpringJoint2D> ().connectedBody = GameObject.Find("Player").rigidbody2D;
		}
	}
}
