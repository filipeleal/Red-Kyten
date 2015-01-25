using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

    public Sprite crosshair;
    public Sprite magnet;

	// Use this for initialization
	void Start () {
        Screen.showCursor = false;
        Activate.active = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Activate.active)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = magnet;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = crosshair;
        }
        var mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
	}
}
