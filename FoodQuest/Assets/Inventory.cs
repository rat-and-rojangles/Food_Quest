using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Represents the inventory of the FoodQuest game

public class Inventory : MonoBehaviour
{

    private List<Item> inventory = new List<Item>();

    void Update()
    {
        //Updates the check for food items
    }

    void Awake()
    {
        // Setting up the reference.
    }


    void OnCollisionEnter(Collision col)
    {
        inventory.Add((Item)col.gameObject.GetComponent<Pizza>());
    }


    void Use()
    {
        
    }
}