using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CustomScriptableObjectArchitecture;

[CreateAssetMenu(
        fileName = "ModifierData.asset",
        menuName = CustomSOArchitecture.MODIFIERDATA_SUBMENU + "Damage Over Time",
        order = CustomSOArchitecture.ASSET_MENU_ORDER_MODIFIERDATA + 0)]
public class DamageOverTimeModifierData : ModifierData
{
    [SerializeField] private float damage;
    [SerializeField] private ParametersGameEvent eventToRaise;

    public override Modifier UnpackModifier(Entity toListen)
    {
        return new DamageOverTimeModifier(damage, baseDuraton, baseTickTime, eventToRaise, toListen);
    }

    public override void UnpackListener(Entity toListen)
    {
        eventToRaise.AddListener((parameters) =>
            {
                if (parameters.entity == toListen)
                    toListen.DamageHealth(parameters.floatValue);
            });
    }
}