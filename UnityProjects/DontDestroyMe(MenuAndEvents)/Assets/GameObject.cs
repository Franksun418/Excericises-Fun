using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        EventManager.AddListener(DestoryMe);
	}

    void DestoryMe() {
        Destroy(gameObject);
    }
}
