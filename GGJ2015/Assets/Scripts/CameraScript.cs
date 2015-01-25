using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject objectToFollow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = new Vector3(objectToFollow.transform.localPosition.x, transform.position.y, transform.position.z);
        transform.position = position;
	}

}
