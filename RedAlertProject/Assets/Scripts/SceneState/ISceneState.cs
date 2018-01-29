using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 场景状态接口
/// </summary>
public class ISceneState
{
    private string mSceneName;
    private SceneStateController controller;

    public ISceneState(string sceneName)
    {
        mSceneName = sceneName;
    }

    public virtual void StateStart()
    {
    }

    public virtual void StateEnd()
    {
    }

    public virtual void StateUpdate()
    {
    }
}