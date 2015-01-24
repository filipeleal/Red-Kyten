using UnityEngine;
using System.Collections;

public class MinionScript : MonoBehaviour {
	public float speed=10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		Vector2 place = new Vector2 ((GameObject.Find ("Player").transform.position.x - 2), gameObject.transform.position.y);
		if (Character.facingRight == true){
			gameObject.transform.position = Vector2.MoveTowards (gameObject.transform.position, place, step );
		}
		else{
			gameObject.transform.position = Vector2.MoveTowards (gameObject.transform.position, new Vector2((GameObject.Find ("Player").transform.position.x+2),gameObject.transform.position.y),step);

		}
	}
}
