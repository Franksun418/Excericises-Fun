using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = Input.mousePosition;
        // position.z = -Camera.main.transform.position.z;
        position.z = -Camera.main.transform.position.z;
        position = Camera.main.ScreenToWorldPoint(position);
        transform.position = position;
        ClampMe();
	}

    void ClampMe() {
        BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();
        float halfWidth = boxCollider2D.size.x /2;
        float halfHeight = boxCollider2D.size.y/2;
        if (transform.position.x - halfWidth <= ScreenUtils.ScreenLeft)
        {
            transform.position = new Vector3(ScreenUtils.ScreenLeft+halfWidth, transform.position.y, transform.position.z);
        }
        else if (transform.position.x + halfWidth >= ScreenUtils.ScreenRight)
        {
            transform.position = new Vector3(ScreenUtils.ScreenRight-halfWidth, transform.position.y, transform.position.z);
        }

        if (transform.position.y - halfWidth <= ScreenUtils.ScreenBottom)
        {
            transform.position = new Vector3(transform.position.x, ScreenUtils.ScreenBottom+halfHeight, transform.position.z);
        }
        else if (transform.position.y + halfHeight >= ScreenUtils.ScreenTop)
        {
            transform.position = new Vector3(transform.position.x, ScreenUtils.ScreenTop-halfHeight, transform.position.z);
        }
    }
}
