using UnityEngine;
using UnityEngine.Events;

using ScriptableObjectArchitecture;

[System.Serializable]
public class TransformEvent : UnityEvent<Transform> { }

[CreateAssetMenu(
    fileName = "TransformVariable.asset",
    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Transform",
    order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 6)]
public sealed class TransformVariable : BaseVariable<Transform, TransformEvent>
{
}