using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonSound;
    public void PlayGame ()
    {
        SceneManager.LoadScene("City");
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

        public void playsButton ()
    {
        buttonSound.Play();
    }

}
