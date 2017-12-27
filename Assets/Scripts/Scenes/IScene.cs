﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IScene : MonoBehaviour
{
    public abstract void Init();
    public abstract void OnStart();
}