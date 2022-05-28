using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterrad : MonoBehaviour
{
    public bool rocksRemoved;
    private bool _wheelRepaired = true;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (rocksRemoved && _wheelRepaired)
        {
            if (anim != null)
            {
                anim.SetBool("repaired", true);
            }
            else
            {
                print("anim is null!");
            }
        }
    }
}
