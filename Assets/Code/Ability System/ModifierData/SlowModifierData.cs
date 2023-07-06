using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

[CreateAssetMenu(
    fileName = "DamageOverTimeModifierData.asset",
    menuName = SOAbilitySystem_Utility.MODIFIERDATA_SUBMENU + "Slow",
    order = SOAbilitySystem_Utility.ASSET_MENU_ORDER_MODIFIERDATA + 0)]
public class SlowModifierData : ModifierData
{
    [Header("Slow Details")]
    [SerializeField] private float slowPercent;

    public override Modifier UnpackModifier(Entity toListen)
    {
        return new SlowModifier(slowPercent, baseDuraton, toListen);
    }

    public override Modifier UnpackModifier()
    {
        throw new System.NotImplementedException();
    }
}
