using UnityEngine;
using System.Collections;

public class GuiRestart : MonoBehaviour {
	public Texture restartbutton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/3 * 2, 500, 100), restartbutton)){
			Application.LoadLevel(1);
		}
	}
}
