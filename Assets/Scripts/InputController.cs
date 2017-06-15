using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : IController
{
    private PlayerController player;

    public override void Init()
    {
        player = GameManager.Instance.GetController<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            player.MoveRight();
        }
    }
}
