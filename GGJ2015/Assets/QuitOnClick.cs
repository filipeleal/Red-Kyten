using UnityEngine;
using System.Collections;

public class QuitOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
            Application.Quit();
        if (Input.GetKey(KeyCode.Space))
        {
            Application.LoadLevel(5);
        }
	}
}
