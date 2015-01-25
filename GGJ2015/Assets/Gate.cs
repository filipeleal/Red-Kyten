using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OpenGate(){
		Vector2 newposition = this.transform.position;
		newposition = new Vector2 (newposition.x, 6);
		this.transform.localPosition = newposition;
	}
}
