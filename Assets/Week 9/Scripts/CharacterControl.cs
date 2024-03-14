using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    public static TextMeshProUGUI villagerType;


    public void Start()
    {
        villagerType = FindObjectOfType<TextMeshProUGUI>();
    }

    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        villagerType.text = SelectedVillager.GetType().Name;



    }

}
