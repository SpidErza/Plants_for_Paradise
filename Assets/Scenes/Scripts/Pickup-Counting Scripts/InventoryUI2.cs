using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI2 : MonoBehaviour
{
    private TextMeshProUGUI emptybottleText;

    // Start is called before the first frame update
    void Start()
    {
        emptybottleText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateItemText(PlayerEmptyBottle bottleInventory)
    {
        emptybottleText.text = bottleInventory.NumberOfEmptyBottles.ToString();
    }
}
