using UnityEngine;
using System.Collections;

public class ControllerBehaviour : MonoBehaviour {
	float axis;
    bool rightSide = true;

	Vector2 velocity;

	public float MaxVelocity = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
        axis = Input.GetAxis("Horizontal");
        if (axis > 0 && !rightSide)
            Flip();
        else if (axis < 0 && rightSide)
            Flip();

        velocity = new Vector2(axis * MaxVelocity, rigidbody2D.velocity.y);
        rigidbody2D.velocity = velocity;
	}

    void Flip()
    {
        rightSide = !rightSide;
        Vector2 newScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        transform.localScale = newScale;
    }
}
