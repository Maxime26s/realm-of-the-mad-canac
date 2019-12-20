using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> database;

    // Start is called before the first frame update
    void Awake()
    {
        string jsonString = File.ReadAllText(Application.dataPath + "/StreamingAssets/ItemDB2.json");
        ItemList itemList = JsonUtility.FromJson<ItemList>(jsonString);
        database = itemList.itemList;
    }

    public Item GetItemByID(int id)
    {
        for (int i = 0; i < database.Count; i++)
            if (database[i].id == id)
                return database[i];
        return null;
    }
}

[Serializable]
public class Item
{
    public int id;
    string name;
    public bool stackable;
    bool equipable;
    public Equipment equipment;
    public Weapon weapon;

    public Item(int id, string name, bool stackable, bool equipable, Weapon weapon)
    {
        this.id = id;
        this.name = name;
        this.stackable = stackable;
        this.equipable = equipable;
        this.weapon = weapon;
    }

    public Item()
    {
        this.id = -1;
    }
}

[Serializable]
public class Equipment
{
    int att;
    int def;
    int spd;
    int dex;
    int vit;
    int wis;
    int hp;
    int mp;
    string slot;

    public Equipment(int att, int def, int spd, int dex, int vit, int wis, int hp, int mp, string slot)
    {
        this.att = att;
        this.def = def;
        this.spd = spd;
        this.dex = dex;
        this.vit = vit;
        this.wis = wis;
        this.hp = hp;
        this.mp = mp;
        this.slot = slot;
    }
}

[Serializable]
public class Weapon
{
    public string type;
    public int tier;
    public int[] damage;
    public float projectileSpeed;
    public float lifetime;

    public Weapon(string type, int tier, int[] damage, float projectileSpeed, float lifetime)
    {
        this.type = type;
        this.tier = tier;
        this.damage = damage;
        this.projectileSpeed = projectileSpeed;
        this.lifetime = lifetime;
    }
}

[Serializable]
public class ItemList
{
    public List<Item> itemList;

    public ItemList(List<Item> itemList)
    {
        this.itemList = itemList;
    }
}