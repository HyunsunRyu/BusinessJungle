using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : IController
{
    [SerializeField] private PlayerData playerData = new PlayerData();
    [SerializeField] private PhysicData physicData = new PhysicData();

    private Vector2 screenSize;

    public override void Init()
    {
        playerData.height = 100f;
        playerData.jumpPower = 100f;
        playerData.speed = 50f;
        screenSize = UIManager.Instance.GetScreenSize();
    }
    
    public void Drop()
    {
    }

    public void Jump()
    {
        physicData.vel.y += playerData.jumpPower;
    }

    public void MoveLeft()
    {
        physicData.vel.x -= playerData.speed * TimeManager.Instance.DeltaTime;
    }

    public void MoveRight()
    {
        physicData.vel.x += playerData.speed * TimeManager.Instance.DeltaTime;
    }

    private void Update()
    {
        Move();
        CheckArea();
    }

    private void Move()
    {
    }

    private void CheckArea()
    {
    }
}
