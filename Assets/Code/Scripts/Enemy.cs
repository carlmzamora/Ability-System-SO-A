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

    private float moveSpeedMultiplier = 1;

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

    /*protected override void Update()
    {
        base.Update();

        HandleMoveSpeedMultipliers();
    }*/

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

    private void HandleMoveSpeedMultipliers()
    {

    }

    private void ApplyMoveSpeedMultipliers()
    {
        //Debug.Log("BEFORE -> base: " + baseMoveSpeed + " | current: " + currentMoveSpeed);
        currentMoveSpeed = Mathf.Clamp((baseMoveSpeed.Value * moveSpeedMultiplier), 100, 2500);
        Debug.Log("AFTER -> base: " + baseMoveSpeed + " | current: " + currentMoveSpeed);
    }

    //TODO: accumulating slow
    public void UpdateMoveSpeedMultipliers(float percent)
    {
        moveSpeedMultiplier += (percent * 0.01f); //should add all the percents

        ApplyMoveSpeedMultipliers();
    }
}