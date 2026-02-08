using UnityEngine;
using System.Collections.Generic;

public class TestJsonSend : MonoBehaviour
{
    public void SendEndTurnTest()
    {
        EndTurnMessage msg = new EndTurnMessage
        {
            action = "endTurn",
            playerId = "P"+PlayerNetwork.LocalPlayer.playerId,
            cardIds = new List<int> { 1, 2 }
        };

        string json = JsonUtility.ToJson(msg);

        if (PlayerNetwork.LocalPlayer != null)
        {
            PlayerNetwork.LocalPlayer.SendJson(json);
        }
        else
        {
            Debug.LogError("LocalPlayer not ready");
        }
    }
}
