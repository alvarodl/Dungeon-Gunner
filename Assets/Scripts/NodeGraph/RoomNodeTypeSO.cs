using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType_", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    public bool displayInNodeGraphEditor = true;
    [Header("One type should be a Corridor")]
    public bool isCorridor;
    [Header("One type should be a CorridorNS")]
    public bool isCorridorNS;
    [Header("One type should be a CorridorEW")]
    public bool isCorridorEW;
    [Header("One type should be a Entrance")]
    public bool isEntrance;
    [Header("One type should be a BossRoom")]
    public bool isBossRoom;
    [Header("One type should be None (unassigned)")]
    public bool isNone;

#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }
#endif
}
