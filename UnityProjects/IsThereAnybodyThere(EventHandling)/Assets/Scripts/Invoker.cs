using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour {

    Timer timer;
    EventA eventA;
    EventB eventB;
    float i;
    private void Awake()
    {
        eventA = new EventA();
        eventB = new EventB();
    }

    // Update is called once per frame
    void Start () {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 1;
        timer.Run();
        EventManager.AddInvoker(this);
	}

    private void Update()
    {
        i += Time.deltaTime;
        if (timer.Finished)
        {
            eventA.Invoke();
            eventB.Invoke((int)i);
            timer.Run();
        }
    }

    public void AddNoArgumentAction(UnityAction unityAction)
    {
        eventA.AddListener(unityAction);
    }
    public void AddOneArgumentAction(UnityAction<int> unityAction)
    {
        eventB.AddListener(unityAction);
    }
}
