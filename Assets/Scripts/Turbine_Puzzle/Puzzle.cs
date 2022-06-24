using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    [SerializeField]
    private List<bool> powered;

    private int correct;

    public List<SpinOnCommand> turbine;

    // void Start()
    // {
    //     for (int i = 0; i < powered.Count; i++)
    //     {
    //         powered[i] = false;
    //     }
    // }

    public void invertTurbine(int buttonUsed)
    {
        //powered[toInvert] = !powered[toInvert];
        switch (buttonUsed)
        {
            case 0: //top left
            {
                //switch 0, 1 & 3
                powered[0] = !powered[0];
                powered[1] = !powered[1];
                powered[3] = !powered[3];
                break;
            }
            case 1: //top middle
            {
                //switch 2, 3 & 4
                powered[2] = !powered[2];
                powered[3] = !powered[3];
                powered[4] = !powered[4];
                break;
            }
            case 2: //top right
            {
                // switch 3, 5 & 6
                powered[3] = !powered[3];
                powered[5] = !powered[5];
                powered[6] = !powered[6];
                break;
            }
            case 3: //bottom left
            {
                //switch 0, 1 & 2
                powered[0] = !powered[0];
                powered[1] = !powered[1];
                powered[2] = !powered[2];
                break;
            }
            case 4: //bottom middle left
            {
                //switch 1, 2 & 3
                powered[1] = !powered[1];
                powered[2] = !powered[2];
                powered[3] = !powered[3];
                break;
            }
            case 5: //bottom middle right
            {
                //switch 3, 4 & 5
                powered[3] = !powered[3];
                powered[4] = !powered[4];
                powered[5] = !powered[5];
                break;
            }
            case 6: //bottom right
            {
                // switch 4, 5 & 6
                powered[4] = !powered[4];
                powered[5] = !powered[5];
                powered[6] = !powered[6];
                break;
            }
        }

        UpdateBools();
    }

    private void UpdateBools()
    {
        correct = 0;
        //set bools equal to what they are in this script
        for (int i = 0; i < turbine.Count; i++)
        {
            turbine[i].spin = powered[i];
            if (powered[i])
            {
                correct++;
            }
        }
        if (correct == turbine.Count) //check if all turbines are on
        {
            Completed();
        }
    }

    private void Completed()
    {
        Destroy(this);
    }
}
