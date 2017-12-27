using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : IManager<SceneManager>
{
    private IScene nowScene;

    protected override void Init()
    {
        nowScene = GetScene();
        nowScene.Init();
    }

    protected override void OnStart()
    {
        nowScene.OnStart();
    }

    private IScene GetScene()
    {
        return GameObject.FindObjectOfType<IScene>();
    }
}
