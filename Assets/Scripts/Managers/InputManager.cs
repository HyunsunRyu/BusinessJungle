using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : IManager<InputManager>
{
    private Vector2 direction;

    private System.Action<Vector2> tiltCallback = null;
    private System.Action dropDownCallback = null;
    
    protected override void Init()
    {
        direction = Vector2.zero;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x -= Time.deltaTime;
            if (direction.x < -1f)
                direction.x = -1f;

            if (tiltCallback != null)
                tiltCallback(direction);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x += Time.deltaTime;
            if (direction.x > 1f)
                direction.x = 1f;

            if (tiltCallback != null)
                tiltCallback(direction);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dropDownCallback != null)
                dropDownCallback();
        }
    }

    public void SetMoveCallback(System.Action<Vector2> callback)
    {
        tiltCallback = callback;
    }

    public void SetDropDownCallback(System.Action callback)
    {
        dropDownCallback = callback;
    }
}
