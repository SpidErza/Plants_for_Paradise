using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    private bool panelOpen;
    public GameObject menu;
    // Update is called once per frame
    void Update()
    {
        panelOpen = FindObjectOfType<openPanel>().inPanel;
        if (!panelOpen)
        {
            if (Input.GetKeyDown("escape"))
            {
                FindObjectOfType<PlayerMovement>().enabled = false;
                FindObjectOfType<MouseLook>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                menu.SetActive(true);
            }
        }
    }
    public void closeMenu()
    {
        FindObjectOfType<PlayerMovement>().enabled = true;
                FindObjectOfType<MouseLook>().enabled = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = false;
                menu.SetActive(false);
    }
}
