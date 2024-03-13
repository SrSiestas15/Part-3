using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ChestType { Villager, Merchant, Archer}
public class Chest : MonoBehaviour
{
    public Animator animator;
    public ChestType whoCanOpen;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Villager>(out Villager villager))
        {
            Debug.Log("check 1");
            if (villager.CanOpen() == whoCanOpen || whoCanOpen == ChestType.Villager)
            {
                Debug.Log("check 2");
                animator.SetBool("IsOpened", true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
