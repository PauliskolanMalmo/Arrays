using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;
    public string name;
    public string description;
}

public class arrayPresentation : MonoBehaviour
{
    public Item[] myItems;
    void Start()
    {
        foreach (var item in myItems)
        {
            print(item.name);
            if (item.itemID == 0)
            {
                print("You have it");
            }
            else
            {
                print("You do not have this item");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomID = Random.Range(0, myItems.Length);

            print("itemID: " + myItems[randomID].itemID + ". Name: " + myItems[randomID].name + ". Description: " + myItems[randomID].description);
        }
    }
}
