using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerRope : MonoBehaviour
{
    public int NumberOfRopes { get; private set; }

    public UnityEvent<PlayerRope> OnRopeCollected;

    public void RopesCollected()
    {
        NumberOfRopes++;
        OnRopeCollected.Invoke(this);
    }
}
