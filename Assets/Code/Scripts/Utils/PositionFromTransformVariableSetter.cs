using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public class PositionFromTransformVariableSetter : MonoBehaviour
{
    [SerializeField] private TransformVariable variableToUse;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        if(variableToUse != null) transform.position = variableToUse.Value.position + offset;
    }
}
