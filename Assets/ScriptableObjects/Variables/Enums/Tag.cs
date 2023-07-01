using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : ScriptableObject
{
    protected List<Tag> destroyOnCollisionList = new List<Tag>();
    public List<Tag> DestroyOnCollisionList { get { return destroyOnCollisionList; } }
}
