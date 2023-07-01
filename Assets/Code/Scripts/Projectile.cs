using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour, ITaggable, IModifiable
{
    [SerializeField] private List<Tag> tags = new List<Tag>();
    public List<Tag> Tags => tags;

    [SerializeField] private FloatReference baseDamage;
    [SerializeField] private float baseTravelSpeed;

    [SerializeField] private List<Modifier> modifiers = new List<Modifier>();
    public List<Modifier> Modifiers => modifiers;

    private Rigidbody rb;

    private float currentDamage;
    public float Damage => currentDamage;

    private float currentTravelSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        currentDamage = baseDamage.Value;
        currentTravelSpeed = baseTravelSpeed;
    }

    private void OnEnable()
    {
        rb.AddForce(transform.forward * currentTravelSpeed);
    }
}
