using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace carlmzamora.AbilitySystem
{
    public interface IModifiable
    {
        List<Modifier> SelfModifiers { get; }
        List<ModifierData> EffectorModifiers { get; }
    }
}