using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CustomScriptableObjectArchitecture;

[CreateAssetMenu(
        fileName = "ProjectileAbility.asset",
        menuName = "Abilities/ProjectileAbility",
        order = 131 + 0)]
public class ProjectileAbility : Ability
{
    [SerializeField] private GameObject projectileToSpawnPrefab;
    [SerializeField] private TransformVariable spawnPoint;

    public override void Activate()
    {
        GameObject projectile = Instantiate(projectileToSpawnPrefab, spawnPoint.Value.position, spawnPoint.Value.rotation);
    }
}