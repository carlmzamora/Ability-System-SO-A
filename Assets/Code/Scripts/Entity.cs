using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour, IDamageable, ITaggable, IModifiable
{
    protected List<Tag> tags = new List<Tag>();
    public List<Tag> Tags
    {
        get { return tags; }
    }

    protected List<Modifier> modifiers = new List<Modifier>();
    public List<Modifier> Modifiers
    {
        get { return modifiers; }
    }

    public virtual void SetHealth(float value)
    {
        throw new System.NotImplementedException();
    }

    public virtual void AddHealth(float amount)
    {
        throw new System.NotImplementedException();
    }
}
