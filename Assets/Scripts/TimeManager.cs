using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance;

    public float DeltaTime { get { return Time.deltaTime; } }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {

    }
}
