using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    //Quiz Objects
    public GameObject Yellowstar, Bluestar, Yellowplanet, Yellowmoon, Blueplanet, YellowstarBlack;

    Vector2 YellowstarInitialPos, BluestarInitialPos, YellowplanetInitialPos, YellowmoonInitialPos, BlueplanetInitialPos;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    bool YellowstarCorrect = false;

	// Use this for initialization
	void Start ()
    {
        YellowstarInitialPos = Yellowstar.transform.position;
        BluestarInitialPos = Bluestar.transform.position;
        YellowplanetInitialPos = Yellowplanet.transform.position;
        YellowmoonInitialPos = Yellowmoon.transform.position;
        BlueplanetInitialPos = Blueplanet.transform.position;
	}

    public void DragYellowStar()
    {
        Yellowstar.transform.position = Input.mousePosition;
    }

    public void DragBlueStar()
    {
        Bluestar.transform.position = Input.mousePosition;
    }

    public void DragYellowPlanet()
    {
        Debug.Log("Test1");
        Yellowplanet.transform.position = Input.mousePosition;
    }

    public void DragYellowMoon()
    {
        Yellowmoon.transform.position = Input.mousePosition;
    }

    public void DragBluePlanet()
    {
        Blueplanet.transform.position = Input.mousePosition;
    }

    public void DropYellowStar()
    {
        float Distance = Vector3.Distance(Yellowstar.transform.position, YellowstarBlack.transform.position);
        if (Distance < 50)
        {
            Yellowstar.transform.position = YellowstarBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            YellowstarCorrect = true;
        }
        else
        {
            Yellowstar.transform.position = YellowstarInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropBlueStar()
    {
        float Distance = Vector3.Distance(BluestarInitialPos, Bluestar.transform.position);
        if (Distance > 50)
        {
            Bluestar.transform.position = BluestarInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropYellowPlanet()
    {
        Debug.Log("Test2");
        float Distance = Vector3.Distance(YellowplanetInitialPos, Yellowplanet.transform.position);
        if (Distance > 50)
        {
            Yellowplanet.transform.position = YellowplanetInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropYellowMoon()
    {
        float Distance = Vector3.Distance(YellowmoonInitialPos, Yellowmoon.transform.position);
        if (Distance > 50)
        {
            Yellowmoon.transform.position = YellowmoonInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropBluePlanet()
    {
        float Distance = Vector3.Distance(BlueplanetInitialPos, Blueplanet.transform.position);
        if (Distance > 50)
        {
            Blueplanet.transform.position = YellowstarBlack.transform.position;
            source.clip = incorrect;
            source.Play();
        }

    }


    void Update()
    {
        if (YellowstarCorrect)
        {
            Debug.Log("Good Job!");
        }
    }



}
