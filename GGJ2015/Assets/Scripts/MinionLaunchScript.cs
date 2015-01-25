using UnityEngine;
using System.Collections;

public class MinionLaunchScript : MonoBehaviour {
	public string effectedbutton;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 4f);
	}
	void OnCollisionEnter2D(Collision2D col){
		Debug.Log (col.gameObject.name);
		if (col.gameObject.name == effectedbutton){
			GameObject.Find (effectedbutton).SendMessage("ButtonFunction",SendMessageOptions.DontRequireReceiver);
		}
	}

}
