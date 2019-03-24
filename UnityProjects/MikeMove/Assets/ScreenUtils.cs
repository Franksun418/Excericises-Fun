using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenUtils {

    static float screenLeft;
    static float screenRight;
    static float screenBottom;
    static float screenTop;

    public static float ScreenLeft {
        get { return screenLeft; }
    }
    public static float ScreenRight {
        get { return screenRight; }
    }
    public static float ScreenTop
    {
        get { return screenTop; }
    }
    public static float ScreenBottom
    {
        get { return screenBottom; }
    }

    public static void Initialize() {
        float screenZ = -Camera.main.transform.position.z;
        Vector3 screenMin = new Vector3 (0, 0, screenZ);
        Vector3 screenMax = new Vector3(Screen.width, Screen.height, screenZ);
        Vector3 WorldMin = Camera.main.ScreenToWorldPoint(screenMin);
        Vector3 WorldMax = Camera.main.ScreenToWorldPoint(screenMax);

        screenLeft = WorldMin.x;
        screenRight = WorldMax.x;
        screenTop = WorldMax.y;
        screenBottom = WorldMin.y;
    }
}
