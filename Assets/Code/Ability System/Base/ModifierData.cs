using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace carlmzamora.AbilitySystem
{
    public abstract class ModifierData : ScriptableObject
    {
        [Header("Base Modifier Details")]
        [SerializeField] protected float baseDuraton;
        [SerializeField] protected float baseTickTime;
        [SerializeField] protected bool onlyAffectsSelf;

        public bool OnlyAffectsSelf => onlyAffectsSelf;

        public abstract Modifier UnpackModifier(Entity toListen);
        public abstract Modifier UnpackModifier();
    }
}