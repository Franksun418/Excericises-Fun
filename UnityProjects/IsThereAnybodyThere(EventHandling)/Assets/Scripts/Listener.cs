using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Listener : MonoBehaviour
{
    private void Start()
    {
        EventManager.AddListener(TryMeSoft);
        EventManager.AddIntListener(HowDareYou);
    }
    void TryMeSoft() {
        print("lol");
    }

    void HowDareYou(int lalala) {
        print (lalala);
    }

}

