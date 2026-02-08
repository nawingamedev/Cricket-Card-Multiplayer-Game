using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIStateMachine : MonoBehaviour
{
    public List<UIbaseStates> uIbaseStates = new();
    private UIbaseStates currentState;
    void Start()
    {
        foreach (UIbaseStates state in uIbaseStates)
        {
            state.gameObject.SetActive(false);
        }

    }
    public void ChangeState(UIbaseStates targetState)
    {
        currentState?.ExitState();
        currentState = targetState;
        currentState.EnterState();
    }
    public void ChangeState(UIStatesEnum targetName)
    {
        foreach (UIbaseStates state in uIbaseStates)
        {
            if (targetName == state.stateName)
            {
                ChangeState(state);
            }
        }
    }
}
public enum UIStatesEnum
{
    NetworkConnectionState,
    GameplayState,
    GameOverState
}

public abstract class UIbaseStates : MonoBehaviour
{
    public UIStatesEnum stateName;
    public abstract void EnterState();
    public abstract void ExitState();
}