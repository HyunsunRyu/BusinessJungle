using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : IScene
{
    private PlayerController player;

    public override void Init()
    {
        player = Util.GetResource<PlayerController>("PlayerPfb/Player");
    }

    public override void OnStart()
    {
        player.transform.parent = UIManager.Instance.GetUIRoot();
    }
}