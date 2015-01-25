using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {
	public float speed=1;
	public float step;
	Vector2 sleepposition;
	// Use this for initialization
	void Start () {
		sleepposition = this.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		step = speed * Time.deltaTime;

	}
	void OpenGate(){
		Vector2 newposition = this.transform.position;
		newposition = new Vector2 (newposition.x, sleepposition.y+5);
		this.transform.localPosition = Vector2.MoveTowards(this.transform.position,newposition,step);
	}	
	void CloseGate(){
		Vector2 newposition = this.transform.position;
		newposition = new Vector2 (newposition.x, sleepposition.y);
		this.transform.localPosition = Vector2.MoveTowards(this.transform.position,newposition,step);
	}
}
