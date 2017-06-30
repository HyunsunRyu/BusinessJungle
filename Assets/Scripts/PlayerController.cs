using UnityEngine;
using System.Collections.Generic;

public class PlayerController : IController
{
    private enum State { OnGround, Jumping, Falling, Attacking }
    
    [SerializeField] private Transform body;
    [SerializeField] private AnimationCurve jumpLineCurve;
    [SerializeField] private AnimationCurve fallLineCurve;
    [SerializeField] private AnimationCurve attackLineCurve;
    [SerializeField] private float jumpingTime;
    [SerializeField] private float fallingTime;
    [SerializeField] private float attackingTime;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float topLine;
    [SerializeField] private float bottomLine;

    private float deltaTime { get { return TimeManager.Instance.DeltaTime; } }

    private float rate;

    private State state;

    public override void Init()
    {
        
    }

    private void Awake()
    {
        state = State.Falling;
        rate = 0f;
    }

    private void Update()
    {
        //float value = Time.realtimeSinceStartup - Mathf.FloorToInt(Time.realtimeSinceStartup);
        //value = Mathf.Abs(value);
        //Debug.LogError(value + "//" + jumpLineCurve.Evaluate(value));

        Move();
    }

    public void MoveLeft()
    {
        Vector3 pos = body.localPosition;
        pos.x -= moveSpeed * deltaTime;
        body.localPosition = pos;
    }

    public void MoveRight()
    {
        Vector3 pos = body.localPosition;
        pos.x += moveSpeed * deltaTime;
        body.localPosition = pos;
    }

    public void Jump()
    {
    }

    public void Attack()
    {
        if (state == State.Jumping || state == State.Falling)
        {
            state = State.Attacking;
        }
    }

    private void Move()
    {
        float value = 0f;

        if (state == State.Jumping)
        {
            rate += Time.deltaTime / jumpingTime;
            if (rate > 1f)
            {
                rate = 1f;
                state = State.Falling;
            }
            value = jumpLineCurve.Evaluate(rate);
        }
        else if (state == State.Falling)
        {
            rate -= Time.deltaTime / fallingTime;
            if (rate < 0f)
            {
                rate = 0f;
                state = State.Jumping;
            }
            value = fallLineCurve.Evaluate(rate);
        }
        else if (state == State.Attacking)
        {
            rate -= Time.deltaTime / attackingTime;
            if (rate < 0f)
            {
                rate = 0f;
                state = State.Jumping;
            }
            value = attackLineCurve.Evaluate(rate);
        }
        
        value = value * (topLine - bottomLine) + bottomLine;
        Vector3 pos = body.localPosition;
        pos.y = value;
        body.localPosition = pos;
    }
}
