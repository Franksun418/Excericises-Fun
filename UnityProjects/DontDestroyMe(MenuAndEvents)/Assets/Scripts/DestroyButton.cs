using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyButton : MonoBehaviour {

    DestoryEvent destoryEvent = new DestoryEvent();

    private void Start()
    {
        EventManager.AddInvoker(this);
    }


    public void AddDestroyEventListener(UnityAction unityAction) {
        destoryEvent.AddListener(unityAction);
    }

    public void Destory() {
        destoryEvent.Invoke();
    }
}
