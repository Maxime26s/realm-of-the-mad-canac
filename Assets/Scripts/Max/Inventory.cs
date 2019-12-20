using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    int slotAmount;
    public GameObject itemDisplay;
    ItemDatabase itemDatabase;
    public List<GameObject> slots = new List<GameObject>();
    public List<Item> items = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {
        itemDatabase = GetComponent<ItemDatabase>();

        slotAmount = 24;
        for(int i = 0; i < slotAmount; i++)
        {
            items.Add(new Item());
            slots[i].GetComponent<Slot>().id = i;
        }

        AddItem(0);
        AddItem(3);
        AddItem(2);
        AddItem(5);
        AddItem(1);
        AddItem(0);
        AddItem(3);
        AddItem(2);
        AddItem(5);
        AddItem(1);
        AddItem(0);
        AddItem(3);
        AddItem(2);
        AddItem(5);
        AddItem(1);
        AddItem(0);
        AddItem(3);
        AddItem(2);
        AddItem(5);
        AddItem(1);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void AddItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItemByID(id);
        if(itemToAdd.stackable && CheckIfInInventory(id))
            for (int i = 0; i < slotAmount; i++)
            {
                if (items[i].id == itemToAdd.id)
                {
                    ItemData itemData = slots[i].GetComponentInChildren<ItemData>();
                    itemData.amount++;
                    itemData.text.text = itemData.amount.ToString();
                    break;
                }
            }
        else
            for (int i = 0; i < slotAmount; i++)
            {
                if (items[i].id == -1)
                {
                    items[i] = itemToAdd;
                    GameObject display = Instantiate(itemDisplay, slots[i].transform);
                    display.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Items/"+id);
                    slots[i].GetComponentInChildren<ItemData>().item = itemToAdd;
                    slots[i].GetComponentInChildren<ItemData>().slot = i;
                    break;
                }
            }
    }

    bool CheckIfInInventory(int id)
    {
        for (int i = 0; i < slotAmount; i++)
            if (items[i].id == id)
                return true;
        return false;
    }
}
