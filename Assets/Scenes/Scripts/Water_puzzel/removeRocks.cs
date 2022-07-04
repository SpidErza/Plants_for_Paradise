using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeRocks : MonoBehaviour
{
    public bool stickGet = false;
    bool rocksRemoved;
    bool playerPresent;
    public GameObject sideRocks;
    public GameObject waterWay;
    void Update()
    {
        if (playerPresent)
        {
            if (Input.GetKeyDown("e") && stickGet)
            {
                if (!rocksRemoved)
                {
                    waterWay.SetActive(false);
                    sideRocks.SetActive(true);
                    rocksRemoved = true;
                    FindObjectOfType<Waterrad>().rocksRemoved = true;
                }
                else
                {
                    waterWay.SetActive(true);
                    sideRocks.SetActive(false);
                    rocksRemoved = false;
                    FindObjectOfType<Waterrad>().rocksRemoved = false;
                }
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "player")
        {
            playerPresent = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "player")
        {
            playerPresent = false;
        }
    }
}
