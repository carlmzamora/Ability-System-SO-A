using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;
using carlmzamora.AbilitySystem;

public class Entity : MonoBehaviour, IDamageable, ITaggable, IModifiable
{
    [SerializeField] protected List<Tag> tags = new();
    public List<Tag> Tags => tags;

    protected List<Modifier> selfModifiers = new();
    public List<Modifier> SelfModifiers => selfModifiers;

    protected List<ModifierData> affectingModifiers = new();
    public List<ModifierData> AffectingModifiers => affectingModifiers;

    [SerializeField] private FloatReference maxHealth;
    public float MaxHealth => maxHealth.Value;

    [SerializeField, ReadOnly] private float currentHealth;
    public float Health => currentHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth.Value;
    }

    private void Update()
    {
        HandleModifiers();
    }

    private void CreateModifier(ModifierData receivedModifierData)
    {
        selfModifiers.Add(receivedModifierData.UnpackModifier(this)); //try to make this object type?
        receivedModifierData.UnpackListener(this);
    }

    private void OnCollisionEnter(Collision other)
    {
        //destroy other if on DestroyOnCollisionList
        ITaggable taggable = other.gameObject.GetComponent<ITaggable>();
        if (taggable != null)
        {
            for (int i = 0; i < tags.Count; i++)
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
        if (proj != null)
        {
            DamageHealth(proj.Damage);

            //check all modifiers, not just one
            CreateModifier(proj.AffectingModifiers[0]);
        }
    }

    public virtual void SetHealth(float value)
    {
        currentHealth = value;
    }

    public virtual void DamageHealth(float value)
    {
        currentHealth = Mathf.Clamp(currentHealth -= value, 0.0f, maxHealth.Value);
    }

    private void HandleModifiers()
    {
        for (int i = 0; i < selfModifiers.Count; i++)
        {
            selfModifiers[i].Update();
        }
    }
}