using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticks : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerStick stickInventory = other.GetComponent<PlayerStick>();

        if (stickInventory != null)
        {
            stickInventory.SticksCollected();
            gameObject.SetActive(false);
        }
    }
}
