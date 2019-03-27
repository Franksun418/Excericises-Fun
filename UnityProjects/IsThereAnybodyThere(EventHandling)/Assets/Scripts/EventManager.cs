using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public static class EventManager {

    public static UnityAction listener;
    public static UnityAction<int> intListener;
    public static Invoker invoker;

    public static void AddListener(UnityAction L)
    {
        listener = L;
        if (invoker != null)
        {
            invoker.AddNoArgumentAction(listener);
        }
    }

    public static void AddIntListener(UnityAction<int> iL)
    {
        intListener = iL;
        if (invoker != null)
        {
            invoker.AddOneArgumentAction(intListener);
        }
    }

    public static void AddInvoker(Invoker invoker)
    {
        if (listener != null)
        {
            invoker.AddNoArgumentAction(listener);
        }
        if (intListener != null)
        {
            invoker.AddOneArgumentAction(intListener);
        }
    }



}
