using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    private Item item;
    private string data;
    public GameObject tooltip;

    private void Start()
    {
        tooltip.SetActive(false);
    }

    private void Update()
    {
        if (tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }

    public void Activate(Item item)
    {
        this.item = item;
        ConstructDataString();
        tooltip.SetActive(true);
    }

    public void Deactivate()
    {
        tooltip.SetActive(false);
    }

    public void ConstructDataString()
    {
        data = "";
        if(item.equipable)
            switch (item.weapon.tier)
            {
                case 0:
                    data += "<#c0c0c0>" + item.name + "</color>";
                    break;
                case 1:
                    data += "<#e6e6e6>" + item.name + "</color>";
                    break;
                case 2:
                    data += "<#add8e6>" + item.name + "</color>";
                    break;
                case 3:
                    data += "<#90ee90>" + item.name + "</color>";
                    break;
                case 4:
                    data += "<#ffa07a>" + item.name + "</color>";
                    break;
                case 5:
                    data += "<#f08080>" + item.name + "</color>";
                    break;
            }
        if (item.weapon != null)
            data += "\n\nType: " + item.weapon.type + "\nTier: " + item.weapon.tier + "\nDamage: " + item.weapon.damage[0] + " - " + item.weapon.damage[1];

        tooltip.GetComponentInChildren<TextMeshProUGUI>().text = data;
    }
}
