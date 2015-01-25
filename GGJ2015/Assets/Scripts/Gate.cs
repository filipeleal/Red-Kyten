using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour
{
    public float speed = 1;
    public float step;
    Vector2 sleepposition;

    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider;

    public Sprite GateOpen;
    public Sprite GateClosed;
    // Use this for initialization
    void Start()
    {
        sleepposition = this.transform.position;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;

    }
    void OpenGate()
    {
        spriteRenderer.sprite = GateOpen;
        //Vector2 newposition = this.transform.position;
        //newposition = new Vector2 (newposition.x, sleepposition.y+5);
        //this.transform.localPosition = Vector2.MoveTowards(this.transform.position,newposition,step);

        boxCollider.enabled = false;
    }
    void CloseGate()
    {
        spriteRenderer.sprite = GateClosed;
        //Vector2 newposition = this.transform.position;
        //newposition = new Vector2 (newposition.x, sleepposition.y);
        //this.transform.localPosition = Vector2.MoveTowards(this.transform.position,newposition,step);
        boxCollider.enabled = true;
    }
}
