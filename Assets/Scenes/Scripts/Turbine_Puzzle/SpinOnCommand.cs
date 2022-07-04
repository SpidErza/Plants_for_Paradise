using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinOnCommand : MonoBehaviour
{
    public bool spin;
    // Update is called once per frame
    void Update()
    {
        if (spin)
        {
            this.gameObject.transform.Rotate(new Vector3(0,0,270 * Time.deltaTime));
        }
    }
}
