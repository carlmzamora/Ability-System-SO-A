using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

[System.Serializable]
public abstract class Modifier
{
    protected bool isInstant;
    protected float currentDuration = 0;
    protected float tickTime = 0;
    protected float nextTickTime = 0;

    protected List<ModifierData> modifiersToAdd;
    public List<ModifierData> ModifiersToAdd => modifiersToAdd;

    //TODO: Add stackable check

    public Modifier() { }    

    public void Update()
    {
        if (isInstant) Do(); //instant
        else //countdown
        {
            if (currentDuration > 0)
            {
                currentDuration -= Time.deltaTime;
                if (currentDuration < nextTickTime)
                {
                    Tick();
                    nextTickTime -= tickTime;
                }
            }
            else
            {
                DisposeSelf();
            }
        }        
    }

    public void Do() { }

    public virtual void Tick() { }

    public virtual void DisposeSelf() { }
}
