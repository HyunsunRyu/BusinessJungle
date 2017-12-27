using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IManager<T> : MonoBehaviour where T : IManager<T>
{
    private bool bInit = false;

    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<T>();
                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(T).Name);
                    instance = obj.AddComponent<T>();
                }
                DontDestroyOnLoad(instance.gameObject);
                instance.Awake();
            }
            return instance;
        }
    }
    
    private void Awake()
    {
        if (bInit)
        {
            if (instance != this)
                Destroy(gameObject);
            return;
        }

        bInit = true;
        Init();
    }

    private void OnEnable()
    {
        OnStart();
    }

    protected abstract void Init();
    protected virtual void OnStart()
    {
    }
}
