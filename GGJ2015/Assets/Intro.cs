using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour
{

    int step;

    public Transform move1;

    public Camera CameraClose;
    public Camera CameraClose2;
    public Camera CameraClose3;
    public Camera CameraClose4;

    public GameObject defaultSprite;

    public ParticleSystem glow;
    // Use this for initialization
    void Start()
    {
        step = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (step)
        {
            case 1:
                Step1();
                break;
            case 2:
                Step2();
                break;
            case 3:
                Step3();
                break;
            case 4:
                Step4();
                break;
            case 5:
                Step5();
                break;
            case 6:
                Step6();
                break;
        }
    }

    void Step1()
    {
        Vector3 destination = new Vector3(move1.position.x, move1.position.y, Camera.main.transform.position.z);
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, destination, 1 * Time.deltaTime);
        if (Camera.main.transform.position.x == destination.x)
        {
            step = 2;
        }
    }

    void Step2()
    {
        if (!CameraClose.gameObject.active)
        {
            CameraClose.gameObject.SetActive(true);
            Camera.main.gameObject.SetActive(false);

            StartCoroutine("Wait", 3f);
        }
        
        
        
    }

    void Step3()
    {
        if (!CameraClose2.gameObject.active)
        {
            CameraClose2.gameObject.SetActive(true);
            CameraClose.gameObject.SetActive(false);
            StartCoroutine("Wait", 3f);
        }

        
        
    }

    void Step4()
    {
        if (!CameraClose3.gameObject.active)
        {
            CameraClose3.gameObject.SetActive(true);
            CameraClose2.gameObject.SetActive(false);
            StartCoroutine("Wait", 3f);
        }

      

    }

    void Step5()
    {
        if (!CameraClose4.gameObject.active)
        {
            CameraClose4.gameObject.SetActive(true);
            CameraClose3.gameObject.SetActive(false);

            defaultSprite.SetActive(false);

            glow.Play();

            StartCoroutine("Wait", 7f);
        }

       

    }

    void Step6()
    {
        Application.LoadLevel("Level1");
    }

    IEnumerator Wait(float seconds)
    {
        //Debug.Log(step);
        yield return new WaitForSeconds(seconds);

        step++;
        //Debug.Log(step);
    }

}
