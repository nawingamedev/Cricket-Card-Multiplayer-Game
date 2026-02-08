using Mirror;
using TMPro;
using UnityEngine;

public class NetworkUIState : UIbaseStates
{
    [SerializeField] GameObject networkPanel;
    [SerializeField] TMP_InputField ip_Address;
    void Awake()
    {
        stateName = UIStatesEnum.NetworkConnectionState;
    }
    public override void EnterState()
    {
        networkPanel.SetActive(true);
    }

    public override void ExitState()
    {
        networkPanel.SetActive(false);
    }
    public void StartHost()
    {
        NetworkManager.singleton.StartHost();
    }
    public void StartClient()
    {
        NetworkManager.singleton.StartClient();
    }
}
