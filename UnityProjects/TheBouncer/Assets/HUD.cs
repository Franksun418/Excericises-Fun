using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour {

    [SerializeField]
    TextMeshProUGUI text;

    int bounceTimes;

    const string bounceTimesPrefixes = "Bounce Times: ";

	// Use this for initialization
	void Start () {
        text.text = bounceTimesPrefixes + bounceTimes.ToString();
	}

    public void AddScore()
    {
        bounceTimes += 1;
        text.text = bounceTimesPrefixes + bounceTimes.ToString();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
