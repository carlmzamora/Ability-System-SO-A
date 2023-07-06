using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace carlmzamora.AbilitySystem
{
    [CreateAssetMenu(
            fileName = "Tag.asset",
            menuName = SOAbilitySystem_Utility.ENUMS_SUBMENU + "Tag",
            order = SOAbilitySystem_Utility.ASSET_MENU_ORDER_ENUMS + 1)]
    public class Tag : ScriptableObject
    {
        [Tooltip("GameObjects that will get destroyed by this GameObject on collision.")]
        public List<Tag> DestroyOnCollisionList = new();
    }
}