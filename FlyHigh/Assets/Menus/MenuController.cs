using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class MenuController : MonoBehaviour
{
    public string newgamelevel;
    private string leveltoload;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(newgamelevel);
    }

    public void LoadGameDialogYes()
    {
        if (PlayerPrefs.HasKey("saveddata")) ;
        {
            leveltoload = PlayerPrefs.GetString("saveddata");
            PlayerPrefs.GetString("saveddata");
        }
    }
}
