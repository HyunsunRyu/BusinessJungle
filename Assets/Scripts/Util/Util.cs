using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    public static T GetResource<T>(string path)
    {
        return (GameObject.Instantiate(Resources.Load(path)) as GameObject).GetComponent<T>();
    }
}
