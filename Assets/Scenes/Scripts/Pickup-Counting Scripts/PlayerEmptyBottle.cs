using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEmptyBottle : MonoBehaviour
{
    public int NumberOfEmptyBottles { get; private set; }

    public UnityEvent<PlayerEmptyBottle> OnEmptyBottleCollected;

    public void EmptyBottlesCollected()
    {
        NumberOfEmptyBottles++;
        OnEmptyBottleCollected.Invoke(this);
    }
}
