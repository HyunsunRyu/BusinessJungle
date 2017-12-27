using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : IManager<UIManager>
{
    [SerializeField] private Transform uiRoot;

    private CanvasScaler canvasScaler;

    protected override void Init()
    {
        canvasScaler = GetComponent<CanvasScaler>();
    }

    public Vector2 GetScreenSize()
    {
        return canvasScaler.referenceResolution;
    }

    public Transform GetUIRoot()
    {
        return uiRoot;
    }
}
