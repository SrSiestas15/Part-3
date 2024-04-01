using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Red : Avatar
{
    float dashPower = 5;
    bool dashing = false;

    protected override void Special()
    {
        if (dashing == false)
        {
            spriteRenderer.color = Color.white;
            StartCoroutine(Dash());
        }
    }

    IEnumerator Dash()
    {
        force *= dashPower;
        dashing = true;
        yield return new WaitForSeconds(.2f);
        spriteRenderer.color = Color.yellow;
        force /= dashPower;
        yield return new WaitForSeconds(1);
        spriteRenderer.color = Color.red;
        dashing = false;
        yield return null;
    }

}
