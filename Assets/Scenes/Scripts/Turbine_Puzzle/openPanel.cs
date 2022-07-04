using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openPanel : MonoBehaviour
{
    private bool inRange;
    private bool inPanel;
    public GameObject Panel;
    public bool WindComplete;

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            if (Input.GetKeyDown("e") && !inPanel)
            {
                FindObjectOfType<PlayerMovement>().enabled = false;
                FindObjectOfType<MouseLook>().enabled = false;
                Panel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                inPanel = true;
            }
            if (Input.GetKeyDown("escape") || WindComplete)
            {
                FindObjectOfType<PlayerMovement>().enabled = true;
                FindObjectOfType<MouseLook>().enabled = true;
                Panel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                inPanel = false;
            }
        }
    }

    void OnTriggerEnter()
    {
        inRange = true;
        // Debug.Log("entered");
    }
    void OnTriggerExit()
    {
        inRange = false;
    }
}
