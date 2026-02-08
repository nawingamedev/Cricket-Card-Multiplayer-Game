using UnityEngine;

public static class JsonMessageRouter
{
    public static void HandleMessage(string json)
    {
        BaseNetMessage baseMsg = JsonUtility.FromJson<BaseNetMessage>(json);
        TextDebugger.instance.DebugLog("Message Recieved :" + baseMsg);
        switch (baseMsg.action)
        {
            case "endTurn":
                Debug.Log("End Turn Received");
                break;

            case "syncBoard":
                Debug.Log("Sync Board Received");
                break;

            case "revealSingleCard":
                Debug.Log("Reveal Card Received");
                break;
        }
    }
}
