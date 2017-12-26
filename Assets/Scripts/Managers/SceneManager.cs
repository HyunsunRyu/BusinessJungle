using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private void Awake()
    {
        IScene scene = GetScene();

        scene.Init();
    }

    private IScene GetScene()
    {
        return GameObject.FindObjectOfType<IScene>();
    }
}
