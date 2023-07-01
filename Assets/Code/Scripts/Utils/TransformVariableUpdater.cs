using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public class TransformVariableUpdater : MonoBehaviour
{
    [SerializeField] private TransformVariable toUpdate;

    private void Awake()
    {
        toUpdate.Value = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        toUpdate.Value = transform;
    }
}
