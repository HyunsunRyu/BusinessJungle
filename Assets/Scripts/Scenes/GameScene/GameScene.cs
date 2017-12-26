using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : IScene
{
    [SerializeField] private GameController gameController;
    
    public override void Init()
    {
        gameController.Init();
    }
}