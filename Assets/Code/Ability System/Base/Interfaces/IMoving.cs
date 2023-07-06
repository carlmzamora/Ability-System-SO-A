using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace carlmzamora.AbilitySystem
{
    public interface IMoving
    {
        float BaseMoveSpeed { get; }
        float MoveSpeed { get; }

        void UpdateMoveSpeedMultipliers(float percent);
    }
}