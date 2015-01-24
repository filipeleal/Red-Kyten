using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject objectToFollow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = new Vector2(objectToFollow.transform.localPosition.x, objectToFollow.transform.localPosition.y);
	}
}
