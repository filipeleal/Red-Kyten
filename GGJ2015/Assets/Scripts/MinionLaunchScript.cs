using UnityEngine;
using System.Collections;

public class MinionLaunchScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 4f);
	}
	void OnCollisionEnter2D(Collision2D col){
		
		if (col.gameObject.GetComponent<buttons>() != null){
            Debug.Log(col.gameObject.name + "<<--");
            col.gameObject.SendMessage("ButtonFunction", SendMessageOptions.DontRequireReceiver);
		}
	}

}
