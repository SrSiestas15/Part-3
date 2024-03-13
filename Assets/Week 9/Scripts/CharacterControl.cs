using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI typeText;
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }

    private void Update()
    {
        if (SelectedVillager != null)
        {
            typeText.text = SelectedVillager.GetType().ToString();
        } else
        {
            typeText.text = "No Selection";
        }
    }
}
