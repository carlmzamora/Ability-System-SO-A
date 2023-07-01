using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public class Entity : MonoBehaviour, IDamageable, ITaggable, IModifiable
{
    [SerializeField] protected List<Tag> tags = new List<Tag>();
    public List<Tag> Tags => tags;

    [SerializeField] protected List<Modifier> modifiers = new List<Modifier>();
    public List<Modifier> Modifiers => modifiers;

    [SerializeField] private FloatReference maxHealth;
    [SerializeField, ReadOnly] private float currentHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth.Value;
    }

    private void OnCollisionEnter(Collision other)
    {
        //destroy other if on DestroyOnCollisionList
        ITaggable taggable = other.gameObject.GetComponent<ITaggable>();
        if(taggable != null)
        {
            for(int i = 0; i < tags.Count; i++)
            {
                Tag ownTag = tags[i];
                for (int j = 0; j < taggable.Tags.Count; j++)
                {
                    Tag otherTag = taggable.Tags[j];
                    if (ownTag.DestroyOnCollisionList.Contains(otherTag))
                    {
                        Destroy(other.gameObject);
                    }
                }
            }
        }

        //take damage if projectile
        Projectile proj = other.gameObject.GetComponent<Projectile>();
        if(proj != null)
        {
            DamageHealth(proj.Damage);
        }
    }

    public virtual void SetHealth(float value)
    {
        currentHealth = value;
    }

    public virtual void DamageHealth(float value)
    {
        currentHealth -= value;
    }
}
