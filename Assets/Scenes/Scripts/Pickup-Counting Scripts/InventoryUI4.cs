using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI4 : MonoBehaviour
{
    private TextMeshProUGUI stickText;

    // Start is called before the first frame update
    void Start()
    {
        stickText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateItemText(PlayerStick playerInventory)
    {
        stickText.text = playerInventory.NumberOfSticks.ToString();
    }
}
