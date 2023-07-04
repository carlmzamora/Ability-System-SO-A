using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour, ITaggable, IModifiable
{
    [SerializeField] private List<Modifier> modifiers = new();
    public List<Modifier> Modifiers => modifiers;

    protected List<ModifierData> storedModifiers = new();
    public List<ModifierData> StoredModifiers => storedModifiers;

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

        for(int i = 0; i < tagsToAdd.Count; i++)
        {
            tags.Add(tagsToAdd[i]);
        }

        ApplyModifiersFromAbility(modifiersFromAbililty);

        gameObject.SetActive(true);
    }

    //should add to own modifiers first??
    //check for activation trigger, like if modifier should be applied immediately
    private void ApplyModifiersFromAbility(List<ModifierData> modifiersFromAbility)
    {
        for (int i = 0; i < modifiersFromAbility.Count; i++)
        {
            storedModifiers.Add(modifiersFromAbility[i]);
        }
    }

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
