using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public abstract class ModifierData : ScriptableObject
{
    [SerializeField] protected float baseDuraton;
    [SerializeField] protected float baseTickTime;

    public abstract Modifier UnpackModifier(Entity toListen);
    public abstract void UnpackListener(Entity toListen);
}