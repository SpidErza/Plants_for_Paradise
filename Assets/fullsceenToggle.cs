using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullsceenToggle : MonoBehaviour
{
    public void Fullsceen(bool is_fullscene)
    {
        Screen.fullScreen = is_fullscene;
    }
}
