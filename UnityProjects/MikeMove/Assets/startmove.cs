using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        GetComponent<Rigidbody2D>().AddForce(direction * 20, ForceMode2D.Impulse);
	}
	
}
