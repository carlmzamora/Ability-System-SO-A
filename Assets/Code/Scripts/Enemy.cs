using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using carlmzamora.AbilitySystem;
using ScriptableObjectArchitecture;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : Entity, IMoving
{
    [SerializeField] private FloatReference baseMoveSpeed;
    public float BaseMoveSpeed => baseMoveSpeed.Value;

    private float moveSpeedMultiplier;

    [SerializeField, ReadOnly] private float currentMoveSpeed;
    public float MoveSpeed => currentMoveSpeed;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        currentMoveSpeed = baseMoveSpeed.Value;
        StartCoroutine(Move());
    }

    protected IEnumerator Move()
    {
        float timer = 0f;
        while(true)
        {
            while(timer < 1.5f)
            {
                timer += Time.deltaTime;
                rb.AddForce(transform.forward * currentMoveSpeed);
                yield return null;
            }
            timer = 0;
            while(timer < 1)
            {
                timer += Time.deltaTime;
                yield return null;
            }
            transform.Rotate(new Vector3(0, 180, 0));
            timer = 0;
        }
    }

    private void ApplyMoveSpeedMultipliers()
    { 
        currentMoveSpeed = baseMoveSpeed.Value * moveSpeedMultiplier;
    }

    //TODO: accumulating slow
    public void UpdateMoveSpeedMultipliers(float percent)
    {
        moveSpeedMultiplier = 1 + (percent * 0.01f); //should add all the percents

        ApplyMoveSpeedMultipliers();
    }
}