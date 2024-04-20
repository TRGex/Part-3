using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryView;
    public GameObject[] Inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inventoryView.activeInHierarchy)
            {
                inventoryView.SetActive(false);
            }
            else
            {
                inventoryView.SetActive(true);
            }
        }
    }
}
