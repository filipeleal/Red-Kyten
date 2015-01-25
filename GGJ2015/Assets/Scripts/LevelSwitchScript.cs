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
		if (col.gameObject.GetComponent<Character>() != null){
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}

	public void LoadFirstLevel ()
	{
		Application.LoadLevel(1);
	}

}
