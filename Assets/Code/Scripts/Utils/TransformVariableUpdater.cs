using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformVariableUpdater : MonoBehaviour
{
    [SerializeField] private TransformVariable toUpdate;

    private void Awake()
    {
        if(toUpdate != null) toUpdate.Value = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        if (toUpdate != null) toUpdate.Value = transform;
    }
}
