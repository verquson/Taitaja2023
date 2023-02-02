using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()

    //kun painaa nappia, se siirt‰‰ k‰ytt‰j‰n seuraavaan sceneen
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    public void QuitGame()

    //lopettaa pelin 
    {
        Application.Quit();

    }
}
