using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;

public class UIBillboardFXAdjuster : MonoBehaviour
{
    public TransformVariable camTransform;

    Quaternion originalRotation;

    void Start()
    {
        originalRotation = transform.rotation;
    }

    void Update()
    {
        transform.rotation = camTransform.Value.rotation * originalRotation;
    }
}