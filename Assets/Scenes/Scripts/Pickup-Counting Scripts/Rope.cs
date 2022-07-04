using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerRope ropeInventory = other.GetComponent<PlayerRope>();

        if (ropeInventory != null)
        {
            ropeInventory.RopesCollected();
            gameObject.SetActive(false);
        }
    }
}
