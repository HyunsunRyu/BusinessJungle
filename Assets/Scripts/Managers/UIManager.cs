using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private CanvasScaler canvasScaler;

    private void Awake()
    {
        Instance = this;

        canvasScaler = GetComponent<CanvasScaler>();
    }

    private void Start()
    {

    }

    public Vector2 GetScreenSize()
    {
        return canvasScaler.referenceResolution;
    }
}
