using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ScriptableObjectArchitecture;
using carlmzamora.AbilitySystem;

[CreateAssetMenu(
        fileName = "ProjectileAbility.asset",
        menuName = SOAbilitySystem_Utility.ABILITIES_SUBMENU + "ProjectileAbility",
        order = SOAbilitySystem_Utility.ASSET_MENU_ORDER_ABILITIES + 0)]
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

    [SerializeField] private List<Tag> projectileTags = new();
    [SerializeField] private List<ModifierData> abilityModifiers = new();

    public override void Activate()
    {
        //TODO: how about ability modifiers that modify the activation? like split shots?
        Projectile projectile = Instantiate(projectileToSpawnPrefab, spawnPoint.Value.position, spawnPoint.Value.rotation).GetComponent<Projectile>();
        projectile.SetupProjectile(baseDamage.Value, baseTravelSpeed, baseLifetime, projectileTags, abilityModifiers);
    }
}