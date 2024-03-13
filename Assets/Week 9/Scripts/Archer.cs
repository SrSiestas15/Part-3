using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrowPrefab;
    public Transform arrowSpawn;

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(arrowPrefab, arrowSpawn.position, arrowSpawn.rotation);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Archer;
    }
}
