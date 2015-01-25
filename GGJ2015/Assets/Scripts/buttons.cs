using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour {
	public bool functioning = false;
	public string effectedgate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (functioning == true){
			gameObject.renderer.material.color = Color.green;
			GameObject.Find(effectedgate).SendMessage("OpenGate",SendMessageOptions.DontRequireReceiver);
		}
		if (functioning == false){
			gameObject.renderer.material.color = Color.red;
		}
	}
		void ButtonFunction(){
			functioning = !functioning;
				
			}
		}
