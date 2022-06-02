using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterrad : MonoBehaviour
{
    public bool rocksRemoved;
    public bool ropeGot;
    private bool _wheelRepaired;
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

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "player")
        {
            if (ropeGot && !rocksRemoved)
            {
                this.gameObject.transform.position.Set(2.5f,1f,8f);
                _wheelRepaired = true;
            }
        }
    }
    void OnTriggerEnter()
    {
        Debug.Log("entered");
    }
}
