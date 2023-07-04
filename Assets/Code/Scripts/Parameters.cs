using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters
{
    public float floatValue;
    public Entity entity;

    //add Dictionaries
    public Parameters(float value, Entity entity)
    {
        floatValue = value;
        this.entity = entity;
    }
}
