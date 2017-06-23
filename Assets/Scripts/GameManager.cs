using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private Dictionary<System.Type, IController> controllerDic = new Dictionary<System.Type, IController>();

    [SerializeField] private InputController inputController;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private MapController mapController;

    private void Awake()
    {
        Instance = this;

        controllerDic.Clear();
    }

    private void Start()
    {
        InitController(playerController);
        InitController(mapController);
        InitController(inputController);
    }

    private void InitController<T>(T controller) where T : IController
    {
        System.Type type = controller.GetType();
        if (!controllerDic.ContainsKey(type))
            controllerDic.Add(type, controller);

        controller.Init();
    }

    public T GetController<T>()  where T : IController
    {
        System.Type type = typeof(T);
        if (controllerDic.ContainsKey(type))
            return controllerDic[type] as T;
        return null;
    }
}
