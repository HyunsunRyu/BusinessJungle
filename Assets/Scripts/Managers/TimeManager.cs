using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : IManager<TimeManager>
{
    public float DeltaTime { get { return Time.deltaTime; } }
    
    protected override void Init()
    {
    }

    private void Start()
    {

    }
}
