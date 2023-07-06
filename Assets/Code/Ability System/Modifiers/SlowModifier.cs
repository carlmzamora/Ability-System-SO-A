using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

public class SlowModifier : Modifier
{
    private float slowPercent;
    private Entity listeningEntity;

    public SlowModifier(float percent, float duration, Entity toListen)
    {
        slowPercent = percent;
        this.currentDuration = duration;
        listeningEntity = toListen;
    }

    public override void Do()
    {
        IMoving moving = listeningEntity.GetComponent<IMoving>();
        if (moving != null)
        {
            moving.UpdateMoveSpeedMultipliers(-slowPercent);
        }
    }

    //TODO: accumulating slow
    public override void DisposeSelf()
    {
        IMoving moving = listeningEntity.GetComponent<IMoving>();
        if (moving != null)
        {
            moving.UpdateMoveSpeedMultipliers(slowPercent);
        }
        listeningEntity.SelfModifiers.Remove(this);
    }
}
