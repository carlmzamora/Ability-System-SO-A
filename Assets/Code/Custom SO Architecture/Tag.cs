using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CustomScriptableObjectArchitecture;

[CreateAssetMenu(
        fileName = "Tag.asset",
        menuName = CustomSOArchitecture.ENUMS_SUBMENU + "Tag",
        order = CustomSOArchitecture.ASSET_MENU_ORDER_ENUMS + 1)]
public class Tag : ScriptableObject
{
    [Tooltip("GameObjects that will get destroyed by this GameObject on collision.")]
    public List<Tag> DestroyOnCollisionList = new();
}