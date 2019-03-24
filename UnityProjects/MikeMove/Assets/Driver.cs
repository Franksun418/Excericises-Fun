using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {


    const float moveUnitsPerSecond = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalX = Input.GetAxis("Horizontal");
        float verticalY = Input.GetAxis("Vertical");
        Vector3 position = transform.position;

        if (horizontalX != 0 && verticalY != 0)
        {
            position.x += horizontalX * moveUnitsPerSecond * Time.deltaTime / Mathf.Sqrt(2);
            position.y += verticalY * moveUnitsPerSecond * Time.deltaTime / Mathf.Sqrt(2); 
        }
        else {
            if (horizontalX != 0)
            {
                position.x += horizontalX * moveUnitsPerSecond * Time.deltaTime; 
            }
            if (verticalY != 0)
            {
                position.y += verticalY * moveUnitsPerSecond * Time.deltaTime; 
            }
        }
        transform.position = position;
	}
}
