using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    // List<Item> items;

	void Start () {
        if (this.gameObject.CompareTag("Player")) {
            // loadPlayerInventory();
        }
	}
	
    void AddItem(object newObject)
    {
        // append newObject to items
    }

    void removeItemByName(string itemName) {
        // remove one item named itemName
    }
}
