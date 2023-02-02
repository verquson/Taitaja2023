using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    public GameObject Regular;
    public GameObject Changed;
    public bool isChanged = false;

    public void BackroundSwitch()
    {
        if (isChanged == false)
        {
            Regular.SetActive(false);
            Changed.SetActive(true);
            isChanged = true;
        }

        else
        {
            Regular.SetActive(true);
            Changed.SetActive(false);
            isChanged = false;
        }
    }
}
