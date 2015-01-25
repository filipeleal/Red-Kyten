using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col){
		Debug.Log (col.gameObject.name);
		if (col.gameObject.GetComponent<Character>() != null){
            col.gameObject.SendMessage("Death", SendMessageOptions.DontRequireReceiver);
		}
	}
}
