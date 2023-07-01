using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public class Ability : ScriptableObject
{
    [SerializeField] public string Name;

    [SerializeField] protected float duration;
    public float Duration => duration;

    [SerializeField] protected float cooldown;
    public float Cooldown => cooldown;

    //add modifierdata list

    public virtual void Activate() { }
}
