using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball {

	// Use this for initialization
	protected override void Start () {
        impulseVector = new Vector2(5, 0);
        base.Start();
	}

    protected override void PrintMessage()
    {
        print("I'ma a red ball!");        
    }
}
