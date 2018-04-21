# UnityEventWithArguments
You can pass arguments with UnityEvent.
Code is based from "https://unity3d.com/jp/learn/tutorials/topics/scripting/events-creating-simple-messaging-system".<br>
<br>
## Example Code
```C#
string eventName = "TEST_EVENT";
EventManager.StartListening(eventName, OnTest);
EventManager.TriggerEvent(eventName, "aaa", 1234);
EventManager.StopListening(eventName, OnTest);
EventManager.TriggerEvent(eventName);

public void OnTest(object[] p){
    Debug.Log(p[0]+","+p[1]);
}       
```