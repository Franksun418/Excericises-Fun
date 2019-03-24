using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>The Resizer class (script) will shrink and grow the game object over time. </summary>
///

public class Resizer : MonoBehaviour {

    const float TotalResizeSeconds = 1;
    const float elapsedResizeSeconds = 0;
    const float ScaleFactorPerSecond = 4;
    int scaleFactorSignMultiplier=-1;
	
	// Update is called once per frame
	void Update () {
        Vector3 newScale = transform.localScale;
        newScale.x += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        newScale.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform.localScale = newScale;
    }
}
