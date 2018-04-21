using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string eventName = "TEST_EVENT";
        EventManager.StartListening(eventName, OnTest);
        EventManager.TriggerEvent(eventName, "aaa", 1234);
        EventManager.StopListening(eventName, OnTest);
        EventManager.TriggerEvent(eventName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTest(object[] p){
        Debug.Log(p[0]+","+p[1]);
    }
}
