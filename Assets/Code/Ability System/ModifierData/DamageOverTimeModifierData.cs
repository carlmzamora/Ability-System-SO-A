using UnityEngine;
using ScriptableObjectArchitecture;
using carlmzamora.AbilitySystem;
using System.Security.Cryptography;

[CreateAssetMenu(
    fileName = "DamageOverTimeModifierData.asset",
    menuName = SOAbilitySystem_Utility.MODIFIERDATA_SUBMENU + "Damage Over Time",
    order = SOAbilitySystem_Utility.ASSET_MENU_ORDER_MODIFIERDATA + 0)]
public class DamageOverTimeModifierData : ModifierData
{
    [Header("Damage Over Time Details")]
    [SerializeField] private float damage;
    [SerializeField] private ParametersGameEvent eventToRaise;

    public override Modifier UnpackModifier(Entity toListen)
    {
        return new DamageOverTimeModifier(damage, baseDuraton, baseTickTime, eventToRaise, toListen);
    }

    public override Modifier UnpackModifier()
    {
        throw new System.NotImplementedException();
    }


    /*public override void UnpackListener(Entity toListen)
    {
        void response(Parameters parameters)
        {
            if (parameters.GetObjectInfo(DamageOverTimeModifier.DAMAGE_OVER_TIME_LISTENER) as Entity == toListen)
                toListen.DamageHealth(parameters.GetFloatInfo(DamageOverTimeModifier.DAMAGE_OVER_TIME_DAMAGE, 0));
        }

        eventToRaise.AddListener(response);
    }*/
}