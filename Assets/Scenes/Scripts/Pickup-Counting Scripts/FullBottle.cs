using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullBottle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerFullBottle fullbottleInventory = other.GetComponent<PlayerFullBottle>();

        if (fullbottleInventory != null)
        {
            fullbottleInventory.FullBottlesCollected();
            gameObject.SetActive(false);
        }
    }
}
