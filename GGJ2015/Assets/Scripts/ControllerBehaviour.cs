using UnityEngine;
using System.Collections;

public class ControllerBehaviour : MonoBehaviour {
	float axis;
    bool rightSide = false;

    bool onFloor = false;
    public Transform floorCheck;
    float floorRadius = 0.2f;
    public LayerMask whatIsFloor;

    GameObject active;

	Vector2 velocity;

    public bool jumpEnabled = true;
	public float MaxVelocity = 10;

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (jumpEnabled)
        {
            if (onFloor && Input.GetButtonDown("Jump"))
            {
                rigidbody2D.AddForce(new Vector2(0, 700));
            }

            animator.SetBool("IsJump", !onFloor);
        }
	}

	void FixedUpdate() {
        onFloor = Physics2D.OverlapCircle(floorCheck.position, floorRadius, whatIsFloor);

        axis = Input.GetAxis("Horizontal");
        //Debug.Log(axis);
        if (axis > 0 && !rightSide)
            Flip();
        else if (axis < 0 && rightSide)
            Flip();

        if (axis != 0)
            animator.SetInteger("Velocity", 1);
        else
            animator.SetInteger("Velocity", 0);
        velocity = new Vector2(axis * MaxVelocity, rigidbody2D.velocity.y);
        rigidbody2D.velocity = velocity;

        if (active != null)
        {
            if (Mathf.Floor(active.transform.position.x) == Mathf.Floor(this.transform.position.x))
            {
                gameObject.GetComponent<SpringJoint2D>().connectedBody = null;
                gameObject.GetComponent<SpringJoint2D>().enabled = false;
                active = null;
            }
        }
	}

    void Flip()
    {
        rightSide = !rightSide;
        Vector2 newScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        transform.localScale = newScale;
    }

    void Grapple(GameObject end)
    {
        Debug.Log(end.transform.position.x);
        gameObject.GetComponent<SpringJoint2D>().enabled = true;
        gameObject.GetComponent<SpringJoint2D>().connectedBody = end.rigidbody2D;
        active = end;

        //			this.transform.position = Vector2.Lerp (this.transform.position, end, step);

    }
}
