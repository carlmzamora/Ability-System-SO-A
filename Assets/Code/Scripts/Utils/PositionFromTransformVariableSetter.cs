using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionFromTransformVariableSetter : MonoBehaviour
{
    [SerializeField] private TransformVariable toSet;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        if(toSet != null) transform.position = toSet.Value.position + offset;
    }
}
