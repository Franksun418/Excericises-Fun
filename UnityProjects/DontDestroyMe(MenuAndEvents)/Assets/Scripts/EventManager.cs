using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager  {
    static DestroyButton Invoker;
    static UnityAction Listener;

    public static void AddInvoker(DestroyButton invoker)
    {
        if (Listener != null)
        {
            invoker.AddDestroyEventListener(Listener);
        }
        Invoker = invoker;
    }

    public static void AddListener(UnityAction unityAction)
    {
        if (Invoker != null)
        {
            Invoker.AddDestroyEventListener(unityAction);
        }
        Listener = unityAction;
    }
}
