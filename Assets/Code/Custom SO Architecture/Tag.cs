using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
        fileName = "Tag.asset",
        menuName = "Enums/Tag",
        order = 132 + 1)]
public class Tag : ScriptableObject
{
    [Tooltip("GameObjects that will get destroyed by this GameObject on collision.")]
    public List<Tag> DestroyOnCollisionList = new List<Tag>();
}