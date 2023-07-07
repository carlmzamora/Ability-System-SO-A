using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

public class MovementSpeedModifier : Modifier
{
    private float changePercent;
    private Entity listeningEntity;

    public MovementSpeedModifier(float percent, float duration, Entity toListen)
    {
        changePercent = percent;
        this.currentDuration = duration;
        listeningEntity = toListen;
    }

    public override void Do()
    {
        IMoving moving = listeningEntity.GetComponent<IMoving>();
        if (moving != null)
        {
            moving.UpdateMoveSpeedMultipliers(changePercent);
        }
    }

    public override void DisposeSelf()
    {
        IMoving moving = listeningEntity.GetComponent<IMoving>();
        if (moving != null)
        {
            moving.UpdateMoveSpeedMultipliers(-changePercent);
        }
        listeningEntity.SelfModifiers.Remove(this);
    }
}
