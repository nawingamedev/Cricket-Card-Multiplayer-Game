using Mirror;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    public static PlayerNetwork LocalPlayer;
    public uint playerId;

    public override void OnStartLocalPlayer()
    {
        LocalPlayer = this;
        playerId = netId;
        Debug.Log("Local Player Ready");
    }

    // CLIENT → SERVER
    public void SendJson(string json)
    {
        if (!isLocalPlayer) return;
        CmdSendJson(json);
    }

    [Command]
    private void CmdSendJson(string json)
    {
        Debug.Log("[SERVER] Received: " + json);
        TextDebugger.instance.DebugLog("[SERVER] Received: " + json);
        RpcReceiveJson(json);
    }

    // SERVER → ALL CLIENTS
    [ClientRpc]
    private void RpcReceiveJson(string json)
    {
        Debug.Log("[CLIENT] Received: " + json);
        TextDebugger.instance.DebugLog("[CLIENT] Received: " + json);
        JsonMessageRouter.HandleMessage(json);
    }
}
