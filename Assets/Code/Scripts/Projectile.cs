using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour, ITaggable, IModifiable
{
    [SerializeField] private List<Modifier> selfModifiers = new();
    public List<Modifier> SelfModifiers => selfModifiers;

    protected List<ModifierData> effectorModifiers = new();
    public List<ModifierData> EffectorModifiers => effectorModifiers;

    private List<Tag> tags = new();
    public List<Tag> Tags => tags;

    private Rigidbody rb;

    private float currentDamage;
    public float Damage => currentDamage;

    private float currentTravelSpeed;
    private float currentLifetime;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
    }

    public void SetupProjectile(float damage, float travelSpeed, float lifetime, List<Tag> tagsToAdd, List<ModifierData> modifiersFromAbililty)
    {
        currentDamage = damage;
        currentTravelSpeed = travelSpeed;
        currentLifetime = lifetime;

        for (int i = 0; i < tagsToAdd.Count; i++)
        {
            tags.Add(tagsToAdd[i]);
        }

        ApplyModifiersFromAbility(modifiersFromAbililty);

        gameObject.SetActive(true);
    }

    //should add to own modifiers first??
    //rename IModifiable StoredModifiers to OtherwardModifiers (modifers not affecting self)
    //rename IModifiable Modifiers to SelfModifiers (modifiers affecting self)
    //modifiers should have affectsSelf bool
    //Create AddModifiersModifierData, which carries anther ModifierData (eg. burning modifier)
    //ApplyModifierFromAbility should now unpack ModifierData (eg. AddModifiersModifierData) to send Modifier to selfModifiers
    //AddModifiersModifierData creates AddModifiersModifier to selfModifiers
    //then CollectOtherwardsModifiersFromSelf should transfer ModifierDatas held by the AddModifiersModifier to otherwardsModifiers

    //ex. burning projectiles ability modifier, affectsSelf=true
    //ability modifier -> ApplyModifierFromAbility -> selfModifiers
    //selfModifiers -> CollectOtherwardsModifiersFromSelf -> otherwardsModifiers
    //proj.otherwardsModifiers -> entity.OnCollision -> entity.SelfModifiers

    //check for activation trigger, like if modifier should be applied immediately
    private void ApplyModifiersFromAbility(List<ModifierData> modifiersFromAbility)
    {
        for (int i = 0; i < modifiersFromAbility.Count; i++)
        {
            //affectingModifiers.Add(modifiersFromAbility[i]);
            selfModifiers.Add(modifiersFromAbility[i].UnpackModifier());
        }

        CollectEffectorModifiersFromSelf();
    }

    private void CollectEffectorModifiersFromSelf()
    {
        for(int i = 0; i < selfModifiers.Count; i++)
        {
            for(int j = 0; j < selfModifiers[i].ModifiersToAdd.Count; j++)
            {
                effectorModifiers.Add(selfModifiers[i].ModifiersToAdd[j]);
            }
        }
    }

    //TODO: how about modifiers that add AOE? OnCollision checks?

    private void OnEnable()
    {
        rb.AddForce(transform.forward * currentTravelSpeed);
        Invoke("Destroy", currentLifetime);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}