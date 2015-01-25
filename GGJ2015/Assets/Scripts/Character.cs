﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {
	public float speed;
	static float step;
	public Rigidbody2D minionsPrefab;
	public Transform minionsLaunch;

	public static bool facingRight = false;

	// Use this for initialization
    
    Animator animator;

	void Start () {
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal");
		//Debug.Log (move);
		if (move != 0){
			rigidbody2D.velocity = new Vector2 (move * speed, rigidbody2D.velocity.y);
             animator.SetInteger("Velocity", 1);
		}
        else{
            animator.SetInteger("Velocity", 0);
        }

        var mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

		if (( mousePos.x > transform.localPosition.x) && !facingRight){
			Flip ();
		}
        else if (( mousePos.x < transform.localPosition.x) && facingRight)
        {
			Flip();
		}
	}
	void Update () {

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("Die", true);
            
                
        }

		if (Input.GetKeyDown (KeyCode.Mouse0) && Activate.active == false && GuiScript.guishow == false) {
			
			
            var mousePos =  Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            
            Rigidbody2D minion = Instantiate(minionsPrefab, minionsLaunch.position, minionsLaunch.rotation) as Rigidbody2D;

            minion.transform.LookAt(mousePos);
            minion.AddForce(minion.transform.forward * 2000f);

		}
	}
	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	void Death(){
		Application.LoadLevel(Application.loadedLevel);

		//Destroy (gameObject);
	}

}
