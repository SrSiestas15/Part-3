using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Blue : Avatar
{
    bool attacking = false;
    public GameObject arrowPrefab;
    public Transform arrowSpawn;


    protected override void Special()
    {
        if (attacking == false)
        {
            spriteRenderer.color = Color.white;
            StartCoroutine(Fire());
        }
    }

    IEnumerator Fire()
    {
        Instantiate(arrowPrefab, arrowSpawn.position, arrowSpawn.rotation);
        attacking = true;
        spriteRenderer.color = Color.yellow;
        yield return new WaitForSeconds(1);
        spriteRenderer.color = Color.blue;
        attacking = false;
        yield return null;
    }
}
