using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeRocks : MonoBehaviour
{
    public bool stickGet = false;
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "player")
        {
            if (Input.GetKey("e"))
            {
                if (stickGet)
                {
                    foreach (GameObject destroy in GameObject.FindGameObjectsWithTag("WaterPuzzleDestroy"))
                    {
                        Destroy(destroy);
                    }
                }
            }
        }
    }
}
