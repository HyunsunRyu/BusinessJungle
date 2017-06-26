using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PhysicData
{
    [SerializeField] public Vector2 vel;
    [SerializeField] public Vector2 pos;
    [SerializeField] public Vector2 acc;
    
    public void Jump(float jumpPower, float deltaTime)
    {
        vel.y += jumpPower;
    }

    public void MoveLeft(float speed, float deltaTime)
    {
        vel.x -= speed * deltaTime;
    }

    public void MoveRight(float speed, float deltaTime)
    {
        vel.x += speed * deltaTime;
    }

    public void CheckArea()
    {
    }

    public Vector3 GetPosition()
    {
        return pos;
    }
}
