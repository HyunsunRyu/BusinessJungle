using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsManager : IManager<AnalyticsManager>
{
    protected override void Init()
    {
        AddEvent("GameStart", new Dictionary<string, string>() { { "Time", System.DateTime.Now.ToString() } });
    }

    private Dictionary<string, object> data = new Dictionary<string, object>();

    public void AddEvent(string eventName, Dictionary<string, string> data)
    {
        this.data.Clear();

        foreach (KeyValuePair<string, string> d in data)
        {
            this.data.Add(d.Key, d.Value);
        }

        Analytics.CustomEvent(eventName, this.data);
    }
}
