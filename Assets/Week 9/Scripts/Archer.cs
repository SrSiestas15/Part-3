using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public override string ToString()
    {
        return "I'm Bob, the archer!";
    }

    public override ChestType CanOpen()
    {
        return ChestType.Archer;
    }
}
