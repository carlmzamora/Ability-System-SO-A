using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

[CreateAssetMenu(
    fileName = "AddsModifiersModifierData.asset",
    menuName = SOAbilitySystem_Utility.MODIFIERDATA_SUBMENU + "Adds Modifiers",
    order = SOAbilitySystem_Utility.ASSET_MENU_ORDER_MODIFIERDATA + 0)]
public class AddsModifiersModifierData : ModifierData
{
    [SerializeField] private List<ModifierData> modifiersToAdd = new();

    public override Modifier UnpackModifier()
    {
        return new AddsModifiersModifier(modifiersToAdd);
    }

    public override Modifier UnpackModifier(Entity toListen)
    {
        throw new System.NotImplementedException();
    }
}
