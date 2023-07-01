using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public interface IDamageable
{
    void SetHealth(float value);
    void DamageHealth(float amount);
}
