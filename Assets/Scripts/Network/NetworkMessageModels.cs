using System;
using System.Collections.Generic;

[Serializable]
public class BaseNetMessage
{
    public string action;
}

[Serializable]
public class EndTurnMessage : BaseNetMessage
{
    public string playerId;
    public List<int> cardIds;
}

[Serializable]
public class SyncBoardMessage : BaseNetMessage
{
    public int opponentCardCount;
}

[Serializable]
public class RevealCardMessage : BaseNetMessage
{
    public string playerId;
    public int cardId;
    public int orderIndex;
}
