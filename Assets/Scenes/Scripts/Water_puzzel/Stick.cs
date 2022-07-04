using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "player" && Input.GetKey("e"))
        {
            FindObjectOfType<removeRocks>().stickGet = true;
            this.transform.parent.gameObject.SetActive(false);
            
        }
    }
}
