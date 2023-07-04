using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOverTimeModifier : Modifier
{
    private float damage;
    private ParametersGameEvent eventToRaise;
    private Entity listeningEntity;

    public DamageOverTimeModifier(float damage, float duration, float tickTime, ParametersGameEvent eventToRaise, Entity toListen)
    {
        currentDuration = duration;
        this.tickTime = tickTime;
        nextTickTime = currentDuration - tickTime;
        this.damage = damage;
        this.eventToRaise = eventToRaise;
        listeningEntity = toListen;
    }

    public override void Tick()
    {
        Parameters parameters = new(damage, listeningEntity);
        eventToRaise.Raise(parameters);
    }
}
