using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public interface IDamageable
{
    float Health { get; }
    float MaxHealth { get; }
    void SetHealth(float value);
    void DamageHealth(float amount);
}
