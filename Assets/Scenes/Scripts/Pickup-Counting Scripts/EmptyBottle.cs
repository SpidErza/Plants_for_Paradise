using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBottle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerEmptyBottle bottleInventory = other.GetComponent<PlayerEmptyBottle>();

        if (bottleInventory != null)
        {
            bottleInventory.EmptyBottlesCollected();
            gameObject.SetActive(false);
        }
    }
}
