using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    //Auttaa siinä että musiikki ei aloita looppia uudestaan kun scene vaihtuu
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
