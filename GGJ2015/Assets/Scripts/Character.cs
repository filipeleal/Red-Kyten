﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {
	public float speed;
	static float step;
	GameObject active;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		step = speed * Time.deltaTime;
	if (Input.GetKey(KeyCode.A)) {
			Vector2 position = this.transform.position;
			position.x--;
			this.transform.position = position;
				}
	if (Input.GetKey(KeyCode.D)) {
			Vector2 position = this.transform.position;
			position.x++;
			this.transform.position = position;
				}

	}

}
