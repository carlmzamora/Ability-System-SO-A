using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

[System.Serializable]
public abstract class Modifier
{
    protected float currentDuration = 0;
    protected float tickTime = 0;
    protected float nextTickTime = 0;

    //TODO: Add stackable check

    public Modifier() { }    

    public void Update()
    {
        if (currentDuration < 0) Do(); //instant
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
            }
        }        
    }

    public void Do() { }

    public virtual void Tick() { }
}
