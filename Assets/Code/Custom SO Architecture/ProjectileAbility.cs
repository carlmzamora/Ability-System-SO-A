using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CustomScriptableObjectArchitecture;
using ScriptableObjectArchitecture;

[CreateAssetMenu(
        fileName = "ProjectileAbility.asset",
        menuName = "Abilities/ProjectileAbility",
        order = 131 + 0)]
public class ProjectileAbility : Ability
{
    [Header("Projectile Ability Properties")]
    [SerializeField] private GameObject projectileToSpawnPrefab;
    [SerializeField] private TransformVariable spawnPoint;

    [Header("Projectile Properties")]

    [SerializeField] private FloatReference baseDamage;
    [SerializeField] private float baseTravelSpeed = 1000;
    [SerializeField] private float baseLifetime = 2;

    [Space(5)]

    [SerializeField] private List<Tag> projectileTags = new List<Tag>();

    public override void Activate()
    {
        Projectile projectile = Instantiate(projectileToSpawnPrefab, spawnPoint.Value.position, spawnPoint.Value.rotation).GetComponent<Projectile>();
        projectile.SetupProjectile(baseDamage.Value, baseTravelSpeed, baseLifetime, projectileTags);
    }
}