using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {
	public static bool guishow = false;

	public Texture guimenu;
	public Texture quit;
	public TextMesh textMesh;
	public Texture2D button;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){
			guishow = !guishow;
		}
	}
	void OnGUI(){
		if (guishow == true){
			GUI.DrawTexture(new Rect((Screen.width/3),(Screen.height/6),Screen.width/3,(Screen.height/3)*2.2f),guimenu);
			if (GUI.Button(new Rect (Screen.width/3+50, Screen.height/2+120, Screen.width/4, Screen.height/8) ,"Quit")){
				Application.Quit();
			}
			if (GUI.Button(new Rect (Screen.width/3+50, Screen.height/2, Screen.width/4, Screen.height/8) ,"Resume")){
				guishow = false;
			}
		}
	}
}