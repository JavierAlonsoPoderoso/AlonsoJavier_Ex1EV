using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiButtons : MonoBehaviour
{
    public void Juego()
    {

        SceneManager.LoadScene("Juego");

    }

    public void Conf()
    {

        SceneManager.LoadScene("Conf");

    }

    public void MenuP()
    {

        SceneManager.LoadScene("MenuP");

    }
}
