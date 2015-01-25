using UnityEngine;
using System.Collections;

public class Minionscript : MonoBehaviour {
	public float speed=10;

    Animator animator;
	// Use this for initialization
	void Start () {
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
        Vector2 place = new Vector2((GameObject.FindGameObjectWithTag("Player").transform.position.x - 2), (GameObject.FindGameObjectWithTag("Player").transform.position.y - 1.4f));
		if (Character.facingRight == true){
			gameObject.transform.position = Vector2.MoveTowards (gameObject.transform.position, place, step );
           
		}
		else{
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, new Vector2((GameObject.FindGameObjectWithTag("Player").transform.position.x + 2), (GameObject.FindGameObjectWithTag("Player").transform.position.y) - 1.4f), step);

		}

        if (GameObject.FindObjectOfType<Character>().move != 0)
        {
            animator.SetInteger("Velocity",1);
        }
        else
        {
            animator.SetInteger("Velocity", 0);
        }

        if (GameObject.FindGameObjectWithTag("Player").transform.position.x > transform.position.x)
        {
            Vector3 theScale = transform.localScale;
            if (theScale.x > 0)
            {
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
        else
        {
            Vector3 theScale = transform.localScale;
            if (theScale.x < 0)
            {
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
	}
}
