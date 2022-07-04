using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerFullBottle : MonoBehaviour
{
    public int NumberOfFullBottles{ get; private set; }

    public UnityEvent<PlayerFullBottle> OnFullBottlesCollected;

    public void FullBottlesCollected()
    {
        NumberOfFullBottles++;
        OnFullBottlesCollected.Invoke(this);
    }
}
