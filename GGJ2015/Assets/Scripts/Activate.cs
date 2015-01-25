using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Activate : MonoBehaviour {
	//Vector2 activeposition;
	public static bool active = false;
	public Rigidbody2D minionsPrefab;
	public Transform minionsLaunch;

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<SpringJoint2D> ().connectedBody != null){
            if (((player.transform.position.x >= (this.transform.position.x - .3) && player.transform.position.x <= (this.transform.position.x + .3))) | (player.transform.position.y >= (this.transform.position.y - 3)))
            {
				gameObject.GetComponent<SpringJoint2D> ().connectedBody = null;
                player.GetComponent<Animator>().SetBool("IsJump", false);
			}
		}
	}
	void OnMouseEnter(){
		active = true;
		//Debug.Log (true);
		}
	void OnMouseExit(){
		active = false;
		//Debug.Log (false);
	}
	IEnumerator OnMouseDown(){
        Debug.Log(player.rigidbody2D);
       
        float dist = Vector2.Distance(player.transform.position, this.transform.position);
		if (dist <= 15f){
//			Grapple();
            player.GetComponent<Animator>().SetBool("IsJump", true);
            gameObject.GetComponent<SpringJoint2D>().connectedBody = player.rigidbody2D;
			yield return new WaitForSeconds(.5f);
		}
	}
//	void Grapple(){
//		Rigidbody2D minion = Instantiate(minionsPrefab, minionsLaunch.position, minionsLaunch.rotation ) as Rigidbody2D;

//	}
}
