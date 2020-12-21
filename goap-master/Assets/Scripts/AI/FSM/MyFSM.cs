using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFSM 
{
    private Stack<MyFSMState> stateStack = new Stack<MyFSMState>();

    public delegate void MyFSMState(MyFSM fsm, GameObject gameObject);


    public void Update(GameObject gameObject)
    {
        if (stateStack.Peek() != null)
            stateStack.Peek().Invoke(this, gameObject);
    }

    public void pushState(MyFSMState state)
    {
        stateStack.Push(state);
    }

    public void popState()
    {
        stateStack.Pop();
    }
}
