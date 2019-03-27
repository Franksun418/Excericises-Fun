using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    [SerializeField]
    Ball[] balls;
    Timer timer;

	// Use this for initialization
	void Start () {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 1;
        timer.Run();
	}
	
	// Update is called once per frame
	void Update () {
        if (timer.Finished)
        {
            int num = Random.Range(0, 3);
            Instantiate(balls[num]);
            timer.Run();
        }
	}
}
