using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    //Auttaa siin� ett� musiikki ei aloita looppia uudestaan kun scene vaihtuu
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
