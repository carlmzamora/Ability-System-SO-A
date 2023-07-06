using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

public class AddsModifiersModifier : Modifier
{
    //TODO: add tagging capability
    public AddsModifiersModifier(List<ModifierData> toAdd)
    {
        modifiersToAdd = toAdd;
    }
}
