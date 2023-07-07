using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

[CreateAssetMenu(
    fileName = "Movement Speed.asset",
    menuName = SOAbilitySystem_Utility.MODIFIERDATA_SUBMENU + "Movement Speed",
    order = SOAbilitySystem_Utility.ASSET_MENU_ORDER_MODIFIERDATA + 0)]
public class MovementSpeedModifierData : ModifierData
{
    [Header("Slow Details")]
    [SerializeField] private float changePercent;

    public override Modifier UnpackModifier(Entity toListen)
    {
        return new MovementSpeedModifier(changePercent, baseDuraton, toListen);
    }

    public override Modifier UnpackModifier()
    {
        throw new System.NotImplementedException();
    }
}
