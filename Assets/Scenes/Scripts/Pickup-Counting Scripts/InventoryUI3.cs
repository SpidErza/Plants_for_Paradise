using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI3 : MonoBehaviour
{
    private TextMeshProUGUI fullBottleText;

    // Start is called before the first frame update
    void Start()
    {
        fullBottleText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateItemText(PlayerFullBottle fullbottleInventory)
    {
        fullBottleText.text = fullbottleInventory.NumberOfFullBottles.ToString();
    }
}
