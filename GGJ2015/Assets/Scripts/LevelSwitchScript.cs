using UnityEngine;
using System.Collections;

public class LevelSwitchScript : MonoBehaviour {
	public int nextlevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player"){
			Application.LoadLevel(nextlevel);
		}
	}

}
