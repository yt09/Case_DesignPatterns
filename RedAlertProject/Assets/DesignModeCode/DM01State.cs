using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***
状态模式原型代码
****/

public class DM01State : MonoBehaviour
{
    private void Start()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));

        context.Handle(25);
        context.Handle(5);
    }
}

/// <summary>
/// 状态拥有者
/// </summary>
public class Context
{
    private IState mState;

    public void SetState(IState state)
    {
        mState = state;
    }

    public void Handle(int arg)
    {
        mState.Handle(arg);
    }
}

public interface IState
{
    void Handle(int args);
}

public class ConcreteStateA : IState
{
    private Context mContext;

    public ConcreteStateA(Context context)
    {
        mContext = context;
    }

    public void Handle(int args)
    {
        Debug.Log("ConcreteStateA.Handle " + args);

        if (args > 10)
        {
            //转换成状态B
            mContext.SetState(new ConcreteStateB(mContext));
        }
    }
}

public class ConcreteStateB : IState
{
    private Context mContext;

    public ConcreteStateB(Context context)
    {
        mContext = context;
    }

    public void Handle(int args)
    {
        Debug.Log("ConcreteStateB.Handle " + args);

        if (args < 10)
        {
            //转换成状态A
            mContext.SetState(new ConcreteStateA(mContext));
        }
    }
}