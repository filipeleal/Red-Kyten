using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {
	public float speed;
	static float step;
	public Rigidbody2D minionsPrefab;
	public Transform minionsLaunch;
	bool facingRight = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal");
		//Debug.Log (move);
		if (move != 0){
			rigidbody2D.velocity = new Vector2 (move * speed, rigidbody2D.velocity.y);
		}
		if (move > 0 && !facingRight){
			Flip ();
		}
		else if(move <0 && facingRight){
			Flip();
		}
	}
	void Update () {

		if (Input.GetKeyDown (KeyCode.Mouse0) && Activate.active == false) {
			Rigidbody2D minion = Instantiate(minionsPrefab, minionsLaunch.position, minionsLaunch.rotation ) as Rigidbody2D;
			Debug.Log (minionsLaunch.forward);
            //minion.AddForce(Input.mousePosition.normalized * -5000f);

            var mousePos =  Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            minion.transform.LookAt(mousePos);
            minion.AddForce(minion.transform.forward * 5000f);

		}
	}
	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
