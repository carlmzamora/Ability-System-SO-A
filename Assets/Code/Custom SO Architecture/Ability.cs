using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

//TODO: make ability data
public class Ability : ScriptableObject
{
    [Header("Ability Details")]
    [SerializeField] public string Name;

    [SerializeField] protected float duration;
    public float Duration => duration;

    [SerializeField] protected float cooldown;
    public float Cooldown => cooldown;

    

    public virtual void Activate() { }
}
