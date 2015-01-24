using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        var mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
	}
}
