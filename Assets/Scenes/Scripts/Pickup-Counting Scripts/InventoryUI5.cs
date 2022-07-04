using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI5 : MonoBehaviour
{
    private TextMeshProUGUI ropeText;

    // Start is called before the first frame update
    void Start()
    {
        ropeText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateItemText(PlayerRope ropeInventory)
    {
        ropeText.text = ropeInventory.NumberOfRopes.ToString();
    }
}
