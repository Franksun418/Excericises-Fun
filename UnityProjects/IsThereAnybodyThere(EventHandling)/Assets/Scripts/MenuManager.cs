using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class MenuManager  {
    public static void GoTo(MenuNames menuNames)
    {
        switch (menuNames)
        {
            case MenuNames.MainPage: {
                    SceneManager.LoadScene("MainMenu");
                }
                break;
            case MenuNames.PauseMenu: {
                    GameObject.Instantiate(Resources.Load("PauseMenu")); 
                }
                break;
        }
    }
}
