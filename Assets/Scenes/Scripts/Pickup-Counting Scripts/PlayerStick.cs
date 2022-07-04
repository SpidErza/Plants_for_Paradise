using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStick : MonoBehaviour
{
    public int NumberOfSticks { get; private set; }

    public UnityEvent<PlayerStick> OnStickCollected;

    public void SticksCollected()
    {
        NumberOfSticks++;
        OnStickCollected.Invoke(this);
    }
}
