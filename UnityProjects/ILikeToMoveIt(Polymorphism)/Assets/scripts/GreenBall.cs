using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball {

	// Use this for initialization
	protected override void Start () {
        impulseVector = new Vector2(0, 5);
        base.Start();

    }

    protected override void PrintMessage()
    {
        print("I'ma going straight up!");
        
        
    }
}
