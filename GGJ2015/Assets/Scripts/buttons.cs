using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour
{
    public bool functioning = true;

    Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetBool("ON", functioning);

        if (functioning == false)
        {
            //gameObject.renderer.material.color = Color.green;
            GameObject.Find("Gate").SendMessage("OpenGate", SendMessageOptions.DontRequireReceiver);
        }

    }
    void ButtonFunction()
    {
        functioning = !functioning;
        Debug.Log(functioning);
    }
}
