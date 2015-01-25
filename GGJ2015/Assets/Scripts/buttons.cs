using UnityEngine;
using System.Collections;


public class buttons : MonoBehaviour
{
    public bool functioning = true;
    public string effectedgate;

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

        if (functioning == true)
        {
            //gameObject.renderer.material.color = Color.green;
            GameObject.Find(effectedgate).SendMessage("OpenGate",SendMessageOptions.DontRequireReceiver);
        }
		else{
			GameObject.Find(effectedgate).SendMessage("CloseGate",SendMessageOptions.DontRequireReceiver);

		}

    }
    void ButtonFunction()
    {
        functioning = !functioning;
        Debug.Log(functioning);
    }
}

			